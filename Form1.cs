using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDataBase.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConnectDataBase
{
    public partial class FormShowData : Form
    {
        public FormShowData()
        {
            InitializeComponent();
            
        }

        List<ConnectionClass> connectionsList = new List<ConnectionClass>();
        

        string procedure = "";
        string procedureList = "";
        int startIndexParameter = -1;
        int endIndexParameter = -1;
        string parameters = "";
        string[] parameterArray;
        string parameterList = "List<SqlParameter> parameters = new List<SqlParameter>\r\n\t\t\t\t\t\t{";

        string integratedSecurity = "false";
        private string connectionStringFileName = "conn.con";

        private void FormShowData_Load(object sender, EventArgs e)
        {

            loadConnectionStringFromFile(connectionStringFileName);
            string serverName = "";
            foreach (var obj in connectionsList)
            {
                txtServer.Text = obj.serverName;
                txtDatabase.Text = obj.databaseName;
                txtTimeout.Text = obj.timeout;
                txtUsername.Text = obj.userName;
                txtPassword.Text = obj.password;

                if (obj.integratedSecurity.ToLower() == "true")
                    rbTrue.Checked = true;
                else
                    rbFalse.Checked = true;

                serverName = obj.serverName + "_" + obj.databaseName;
                cbSelectFile.Items.Add(serverName);
            }
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);
            rbtnTables.Checked = true;
        }
      
        private void LoadConnections()
        {
            
        }
        private void resetGenList()
        {
            
            startIndexParameter = -1;
            endIndexParameter = -1;
            parameters = "";
            
            parameterList = "List<SqlParameter> parameters = new List<SqlParameter>\r\n\t\t\t\t\t\t{";
     
        }
        string procedureType = "";
        string begin = "BEGIN" + Environment.NewLine;
        string end = "END" + Environment.NewLine;
        string whereClause = "";
        private void resetGenProcedure()
        {
            procedure = "CREATE PROCEDURE [dbo].[";
            
            begin = "BEGIN" + Environment.NewLine;
            end = "END" + Environment.NewLine;
            whereClause = "";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);
            if(rbtnTables.Checked)
            {
                loadTables();
                btnData.Text = "Data";
                btnGenerateProcedure.Text = "Gen Procedure";
                btnTableDesign.Enabled = true;
            }
            else if(rbtnProcedures.Checked)
            {
                loadProcedures();
                btnData.Text = "Procedure";
                btnGenerateProcedure.Text = "Get List";
                btnTableDesign.Enabled = false;
            }
        }

        private void loadTables()
        {
            try
            {
                lblMessage.Text = "";
                string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='" + txtDatabase.Text + "' order by TABLE_NAME";
                DataSet objDataSet = StaticClass.LoadData(query);
                lstBoxTables.Items.Clear();
                foreach (DataRow row in objDataSet.Tables[0].Rows)
                {
                    lstBoxTables.Items.Add(row["TABLE_NAME"].ToString());
                }
                lblMessage.Text = objDataSet.Tables[0].Rows.Count.ToString() + " Tables Loaded Successfully";

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void loadProcedures()
        {
            try
            {
                lblMessage.Text = "";
                string query = "Select * FROM sys.procedures where [type] = 'P' AND [name] not like 'sp[_]%diagram%' order by name";
                DataSet objDataSet = StaticClass.LoadData(query);
                lstBoxTables.Items.Clear();
                StaticClass.listProcedures.Clear();
                foreach (DataRow row in objDataSet.Tables[0].Rows)
                {
                    lstBoxTables.Items.Add(row["name"].ToString());
                    StaticClass.listProcedures.Add(new KeyValuePair<string, string>(row["name"].ToString(), row["object_id"].ToString()));
                }
                lblMessage.Text = objDataSet.Tables[0].Rows.Count.ToString() + " Procedures Loaded Successfully";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

       
        private void lstBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                        
        }

        private void getProcedure(string procedureName)
        {
            try
            {

                string object_Id = StaticClass.listProcedures[lstBoxTables.SelectedIndex].Value;
                string query = "SELECT definition FROM sys.sql_modules WHERE object_id = " + object_Id; //439672614 ";//(OBJECT_ID(N'" + procedureName + "'))";
                DataSet proceduresDataSet = StaticClass.LoadData(query);
                txtQuery.Text = proceduresDataSet.Tables[0].Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        BindingSource bindingSource1 = new BindingSource();
        private void GetData(string selectCommand)
        {
            dgView.DataSource = bindingSource1;
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = StaticClass.connnectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                lblMessage.Text = (dgView.Rows.Count - 1).ToString() + " rows loaded Sucessfully";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateData()
        {
            try
            {
                // Update the database with the user's changes.
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuery.Text.Length < 5)
                    return;
                string query = "";
                if (txtQuery.SelectedText.Length > 0)
                    query = txtQuery.SelectedText;
                else
                    query = txtQuery.Text;                
                if (query.ToUpper().Contains("SELECT "))
                {
                    GetData(query);
                    lblMessage.Text = dgView.Rows.Count.ToString() + " Rows Loaded Sucessfully";
                }
                else
                {
                    //StaticClass.connnectionString = txtConnectionString.Text;
                    StaticClass.ExceuteQuery(txtQuery.Text);
                    lblMessage.Text = "Command Executed sucessfully";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);

        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);

        }

        private void txtIntegratedSecurity_TextChanged(object sender, EventArgs e)
        {
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);

        }

        private void txtTimeout_TextChanged(object sender, EventArgs e)
        {
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            StaticClass.updateConnectionString(txtServer.Text, txtDatabase.Text, integratedSecurity, txtTimeout.Text, txtUsername.Text, txtPassword.Text);

        }

        private void rbtnTables_CheckedChanged(object sender, EventArgs e)
        {
            btnLoad_Click(sender, e);
        }

        private void rbtnProcedures_CheckedChanged(object sender, EventArgs e)
        {
            dgView.DataSource = null;
            dgView.RefreshEdit();
            btnLoad_Click(sender, e);
        }

        private void btnTableDesign_Click(object sender, EventArgs e)
        {
            txtQuery.Text = " SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH AS SIZE, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + this.lstBoxTables.SelectedItem.ToString() + "'";
            btnRun_Click(sender, e);
            
            txtQuery.Text = "";
        }
        private void loadDesign()
        {
            char ch = '"';

            SqlConnection dbConn = new SqlConnection(StaticClass.connnectionString);
            DataTable data = new DataTable();
          ;
            SqlCommand dbCmd = new SqlCommand();
            //dbConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ch + this.stringData + ch;
            dbConn.Open();
            dbCmd.Connection = dbConn;
            dbCmd.CommandText = " SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH AS SIZE, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + this.lstBoxTables.SelectedItem.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(dbCmd);
            adapter.Fill(data);
            var dataTable = new DataTable();
            dataTable.Columns.Add("ColumnName");
            dataTable.Columns.Add("ColumnType");
            dataTable.Columns.Add("Size");

            foreach (DataColumn column in data.Columns)
            {
                dataTable.Rows.Add(column.ColumnName, column.DataType.ToString(), column.AutoIncrement.ToString());
            }

            this.dgView.DataSource = dataTable;

            this.lblMessage.Text = data.Rows.Count.ToString();

            dbConn.Close();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            if (rbtnTables.Checked)
                GetData("select * from " + lstBoxTables.SelectedItem.ToString());
            else if (rbtnProcedures.Checked)
            {
                getProcedure(lstBoxTables.SelectedItem.ToString());
            }
        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

  

        private void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(lbxParameters.Items.Count > 0)
            {
                for (int i = 0; i < lbxParameters.Items.Count; i++)
                {
                    if (!lbxParameters.GetItemChecked(i) && chbSelectAll.Checked)
                    {
                        lbxParameters.SetItemChecked(i, true);
                        //do something with checkedListBox2.Items[i]
                    }
                    else if(lbxParameters.GetItemChecked(i) && !chbSelectAll.Checked)
                    {
                        lbxParameters.SetItemChecked(i, false);
                        //do something else with checkedListBox2.Items[i]
                    }
                }
            }
        }

        private void btnGenerateProcedure_Click(object sender, EventArgs e)
        {
            if (rbtnTables.Checked)
            {
                StaticClass.dsTableDesign.Clear();

                string query = " SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH AS SIZE, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + this.lstBoxTables.SelectedItem.ToString() + "'";
                StaticClass.dsTableDesign = StaticClass.LoadData(query);
                tbTableName.Text = this.lstBoxTables.SelectedItem.ToString();
                tbProcedureName.Text = this.lstBoxTables.SelectedItem.ToString();
                btnLoadTableParameter_Click(sender, e);
                chbSelectAll.Checked = false;
                tabConnection.SelectedIndex = 1;

            }
            else if (rbtnProcedures.Checked)
            {
                getProcedure(lstBoxTables.SelectedItem.ToString());

                tbProcedure.Text = "";
                tbParameterList.Text = "";

                btnData_Click(sender, e);
                tbProcedure.Text = txtQuery.Text;
                btnGenerateList_Click(sender, e);
                tabConnection.SelectedIndex = 1;
            }
        }

        private void btnGenerateList_Click(object sender, EventArgs e)
        {
            resetGenList();
            generateList();
        }
        private void generateList()
        {
            try
            {
                lblMessage.Text = "";
                parameters = "";
                parameterArray = null;
                parameterList = "List<SqlParameter> parameters = new List<SqlParameter>\r\n\t\t\t\t\t\t{\r\n\t\t\t\t\t\t\t";
                // StartIndexParameter------------------------------------------------------------------------------

                startIndexParameter = procedureList.IndexOf("\r\n@");        // Find First Parameter
                if (startIndexParameter < 0)
                    startIndexParameter = procedureList.IndexOf("@");        // Find First Parameter
                if (startIndexParameter < 0)
                {
                    lblMessage.Text = "Sorry No Parameter Found";
                    return;
                }
                //else
                   // startIndexParameter += 2;

                // EndIndexParameter---------------------------------------------------------------------------------

                 endIndexParameter = procedureList.IndexOf("\r\nAs");
                if (endIndexParameter < 0)
                    endIndexParameter = procedureList.IndexOf("As");
                if (endIndexParameter < 0)
                {
                    lblMessage.Text += "               This is not proper procedure";
                }

                // If Procedure With Paramerter Found-----------------------------------------------------------------

                parameters = procedureList.Substring(startIndexParameter, endIndexParameter - startIndexParameter);

                //tbParameter.Text = "Parametars are as" + Environment.NewLine + parameters;
                //tbParameter.Text = parameterList;

                GenerateList();
                tbParameterList.Text = parameterList;

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
        string newParmerter = "new SqlParameter(\"";
        string defaultValue = "";
        private void GenerateList()
        {
            bool isFirst = true;
            string dataType = "";

            parameterArray = parameters.Split(','); // Add parameters in array by seperating with comma
            foreach (string parameter in parameterArray)
            {
                dataType = "";
                defaultValue = "";
                string parameterNamePart = newParmerter;
                string[] parameterParts = parameter.Trim().Split(' '); // split parameter into name and dataType
                dataType = GetDataType(parameterParts[1]);



                if (isFirst)                         // For First Iteration
                {
                    isFirst = false;
                    parameterNamePart += parameterParts[0] + "\", SqlDbType." + dataType + ") { Value = " + defaultValue + " }";
                    parameterList += parameterNamePart;
                }
                else
                {
                    parameterList += ",\r\n\t\t\t\t\t\t\t " + parameterNamePart + parameterParts[0] + "\", SqlDbType." + dataType + ") { Value = " + defaultValue + " }";
                }
            }
            parameterList += "\r\n\t\t\t\t\t\t};";

        }
        private string GetDataType(string arrayIndex)
        {
            string type = arrayIndex;
            if (type.ToLower().Contains("int") || type.ToLower().Contains("numeric"))
            {
                type = "Int";
                defaultValue = "0";
            }
            else if (type.ToLower().Contains("date"))
            {
                type = "Date";
                defaultValue = "\"\"";
            }
            else if (type.ToLower().Contains("decimal"))
            {
                type = "Decimal";
                defaultValue = "0";
            }
            else if (type.ToLower().Contains("bit"))
            {
                type = "Bit";
                defaultValue = "false";
            }
            else if (type.ToLower().Contains("varchar"))
            {
                string[] partType = type.Split('(', ')');
                type = "VarChar, " + partType[1];
                defaultValue = "\"\"";
            }
            return type;
        }

        private void tbProcedure_TextChanged(object sender, EventArgs e)
        {
            if (tbProcedure.Text.Length > 0)
            {
                procedureList = tbProcedure.Text;
            }
        }

        private void btnGenereateProcedure_Click_1(object sender, EventArgs e)
        {
            resetGenProcedure();
            generateProcedure();
        }

        private void generateProcedure()
        {
            procedure = "CREATE PROCEDURE [dbo].[";
            procedure += procedureType + tbProcedureName.Text + "]" + Environment.NewLine;  // End of First line
            procedure += GetParemeters() + Environment.NewLine;            // Now Add parameters if any
            procedure += "As" + Environment.NewLine;
            procedure += begin;

            procedure += GetProcedureQuery() + Environment.NewLine;
            procedure += whereClause;

            procedure += Environment.NewLine + end;

            tbProcedure.Text = procedure; // Load Procedure to textbox
        }
        private string GetParemeters()
        {
            string parameter = "";
            if (lbxParameters.CheckedItems.Count > 0)
            { // now combine all parameters
                bool isFirstValue = true;
                int i = -1;
                foreach (string item in lbxParameters.Items)
                {
                    if (lbxParameters.GetItemChecked(++i))
                    {
                        if (isFirstValue)
                        {
                            parameter = item;
                            isFirstValue = false;
                        }
                        else
                            parameter += ", " + item;
                    }

                }

            }
            return parameter;
        }
        ///-------------------------------------------------------------------------------------GetProcedureQuery()------------------------------------------------------------
        List<string> listParameter = new List<string>();
        List<string> listColumns = new List<string>();
        string dataType = "";
        
        private string GetProcedureQuery()
        {
            string query = "";

            if (rbtnLoad.Checked) // For generating Load Query
            {
                if (lbxParameters.Items.Count > 0)
                {
                    query = Environment.NewLine + "Select ";
                    bool isFirstValue = true;
                    foreach (string item in listColumns)
                    {
                        if (isFirstValue)
                        {
                            query += item;
                            isFirstValue = false;
                        }
                        else
                            query += ", " + item;

                    }
                    query += " FROM " + tbTableName.Text;

                }
                else   // to select all columns available
                    query = "SELECT * FROM " + tbTableName.Text;
            }
            else if (rbtnUpdate.Checked)
            {
                if (lbxParameters.CheckedItems.Count > 0)
                {
                    query = Environment.NewLine + "UPDATE " + tbTableName.Text + " SET ";
                    bool isFirstValue = true;
                    int index = -1;
                    foreach (string item in listParameter)
                    {
                        ++index;
                        string value = "";
                        value = listParameter[index];
                        if (lbxParameters.GetItemChecked(index))
                        {

                            if (isFirstValue)
                            {

                                query += "[" + listColumns[index] + "] = " + value;
                                isFirstValue = false;
                            }
                            else
                                query += ", [" + listColumns[index] + "] = " + value;
                        }

                    }
                 
                    //query += " FROM " + tbTableName.Text;

                }
                else
                    MessageBox.Show("Please Insert Parameter(s) to update");
            }
            else if (rbtnInsert.Checked)
            {
                if (lbxParameters.Items.Count > 0)
                {
                    query = Environment.NewLine + "INSERT INTO " + tbTableName.Text + " ";
                    bool isFirstValue = true;
                    int index = -1;
                    string columns = "";
                    string values = "";
                    foreach (string item in listParameter)
                    {
                        ++index;
                        string value = "";
                        if (lbxParameters.GetItemChecked(index))
                        {
                            if (isFirstValue)
                            {

                                columns += "[" + listColumns[index] + "]";
                                values += listParameter[index];

                                isFirstValue = false;
                            }
                            else
                            {
                                columns += ", [" + listColumns[index] + "]";
                                values += ", " + listParameter[index];
                            }
                        }

                    }
                    query += "( " + columns + " ) VALUES ( " + values + " )";

                }
                else
                    MessageBox.Show("Please Insert Parameter(s) to insert");
            }

            return query;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLoadTableParameter_Click(object sender, EventArgs e)
        {
            try
            {
                lbxParameters.Items.Clear();
                tbProcedure.Text = "";
                tbParameterList.Text = "";
                listColumns.Clear();
                listParameter.Clear();
                if (StaticClass.dsTableDesign.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in StaticClass.dsTableDesign.Tables[0].Rows)
                    {
                        string parameter = "@" + row["COLUMN_NAME"];
                        listParameter.Add(parameter);
                        listColumns.Add(row["COLUMN_NAME"].ToString());

                        parameter +=" " + row["DATA_TYPE"];
                        string size = row["SIZE"].ToString();
                        if(size.Length > 0)
                        {
                            parameter = parameter + "(" + size + ")";
                        }
                        lbxParameters.Items.Add(parameter);
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtnLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLoad.Checked)
                procedureType = "Load_";
        }

        private void rbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUpdate.Checked)
            {
                procedureType = "Update_";

            }
        }

        private void rbtnInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInsert.Checked)
            {
                procedureType = "Add_";

            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            rbtnLoad.Checked = true;
        }

        private void rbTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrue.Checked)
                integratedSecurity = "true";
            else
                integratedSecurity = "false";
        }

        private void rbFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrue.Checked)
                integratedSecurity = "true";
            else
                integratedSecurity = "false";
        }

        private void tPMain_Click(object sender, EventArgs e)
        {

        }

        private void chbCreateNewFile_CheckedChanged(object sender, EventArgs e)
        {
            if(chbCreateNewFile.Checked)
            {
                btnUpdateConnections.Enabled = true;
                
            }
            else
            {
                btnUpdateConnections.Enabled = false;
                
            }
        }

        private void btnUpdateConnections_Click(object sender, EventArgs e)
        {
            
            addToListConnections();
            saveConnectionStringToFile(connectionStringFileName);

        }
       
        private void addToListConnections()
        {
            ConnectionClass objConnectionClass = new ConnectionClass();
            objConnectionClass.serverName = txtServer.Text;
            objConnectionClass.databaseName = txtDatabase.Text;
            objConnectionClass.integratedSecurity = integratedSecurity;
            objConnectionClass.timeout = txtTimeout.Text;
            objConnectionClass.userName = txtUsername.Text;
            objConnectionClass.password = txtPassword.Text;

            connectionsList.Add(objConnectionClass);
        }
        public void saveConnectionStringToFile(String fileName)
        {
   
            // Open a file and serialize the object into it in binary format.
            // EmployeeInfo.osl is the file that we are creating. 
            // Note:- you can give any extension you want for your file
            // If you use custom extensions, then the user will now 
            //   that the file is associated with your program.

            try
            {
                SerializableConnection objSerializableConnection = new SerializableConnection();
                objSerializableConnection.connectionList = connectionsList;
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();


                bformatter.Serialize(stream, objSerializableConnection);
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public  void loadConnectionStringFromFile(string FileName)
        {

            try
            {
                //Open the file written above and read values from it.
                Stream stream = File.Open(FileName, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

                SerializableConnection objSerializableConnection = new SerializableConnection();

                objSerializableConnection = (SerializableConnection)bformatter.Deserialize(stream);
                connectionsList = objSerializableConnection.connectionList;
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void cbSelectFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDatabase.Text = connectionsList[cbSelectFile.SelectedIndex].databaseName;
            txtServer.Text = connectionsList[cbSelectFile.SelectedIndex].serverName;
                txtDatabase.Text = connectionsList[cbSelectFile.SelectedIndex].databaseName;
                txtTimeout.Text = connectionsList[cbSelectFile.SelectedIndex].timeout;
                txtUsername.Text = connectionsList[cbSelectFile.SelectedIndex].userName;
                txtPassword.Text = connectionsList[cbSelectFile.SelectedIndex].password;

                if (connectionsList[cbSelectFile.SelectedIndex].integratedSecurity.ToLower() == "true")
                    rbTrue.Checked = true;
                else
                    rbFalse.Checked = true;

        }

    }
}
