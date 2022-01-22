namespace ConnectDataBase
{
    partial class FormShowData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabConnection = new System.Windows.Forms.TabControl();
            this.tPMain = new System.Windows.Forms.TabPage();
            this.chbCreateNewFile = new System.Windows.Forms.CheckBox();
            this.btnUpdateConnections = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSelectFile = new System.Windows.Forms.ComboBox();
            this.btnGenerateProcedure = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnTableDesign = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlSelectCategory = new System.Windows.Forms.Panel();
            this.rbtnProcedures = new System.Windows.Forms.RadioButton();
            this.rbtnTables = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstBoxTables = new System.Windows.Forms.ListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.tpGenerateProcedure = new System.Windows.Forms.TabPage();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbParameterList = new System.Windows.Forms.RichTextBox();
            this.tbWhere = new System.Windows.Forms.RichTextBox();
            this.tbProcedure = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddWhereClause = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLoadTableParameter = new System.Windows.Forms.Button();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.lbxParameters = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGenereateProcedure = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbProcedureName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlParameterType = new System.Windows.Forms.Panel();
            this.rbtnDecimal = new System.Windows.Forms.RadioButton();
            this.rbtnBit = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnVarchar = new System.Windows.Forms.RadioButton();
            this.rbtnInt = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.pnlProcedureType = new System.Windows.Forms.Panel();
            this.rbtnDelete = new System.Windows.Forms.RadioButton();
            this.rbtnInsert = new System.Windows.Forms.RadioButton();
            this.rbtnUpdate = new System.Windows.Forms.RadioButton();
            this.rbtnLoad = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tPMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSelectCategory.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.tpGenerateProcedure.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlParameterType.SuspendLayout();
            this.pnlProcedureType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.tabConnection);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1254, 682);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // tabConnection
            // 
            this.tabConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConnection.Controls.Add(this.tPMain);
            this.tabConnection.Controls.Add(this.tpGenerateProcedure);
            this.tabConnection.Location = new System.Drawing.Point(12, 12);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.SelectedIndex = 0;
            this.tabConnection.Size = new System.Drawing.Size(1234, 667);
            this.tabConnection.TabIndex = 0;
            // 
            // tPMain
            // 
            this.tPMain.Controls.Add(this.chbCreateNewFile);
            this.tPMain.Controls.Add(this.btnUpdateConnections);
            this.tPMain.Controls.Add(this.panel1);
            this.tPMain.Controls.Add(this.label15);
            this.tPMain.Controls.Add(this.cbSelectFile);
            this.tPMain.Controls.Add(this.btnGenerateProcedure);
            this.tPMain.Controls.Add(this.btnData);
            this.tPMain.Controls.Add(this.btnTableDesign);
            this.tPMain.Controls.Add(this.txtQuery);
            this.tPMain.Controls.Add(this.txtPassword);
            this.tPMain.Controls.Add(this.txtUsername);
            this.tPMain.Controls.Add(this.txtTimeout);
            this.tPMain.Controls.Add(this.txtDatabase);
            this.tPMain.Controls.Add(this.txtServer);
            this.tPMain.Controls.Add(this.lblMessage);
            this.tPMain.Controls.Add(this.pnlSelectCategory);
            this.tPMain.Controls.Add(this.label8);
            this.tPMain.Controls.Add(this.label7);
            this.tPMain.Controls.Add(this.label6);
            this.tPMain.Controls.Add(this.label5);
            this.tPMain.Controls.Add(this.label1);
            this.tPMain.Controls.Add(this.label4);
            this.tPMain.Controls.Add(this.btnUpdate);
            this.tPMain.Controls.Add(this.lstBoxTables);
            this.tPMain.Controls.Add(this.btnRun);
            this.tPMain.Controls.Add(this.label2);
            this.tPMain.Controls.Add(this.btnLoad);
            this.tPMain.Controls.Add(this.pnlDataGridView);
            this.tPMain.Location = new System.Drawing.Point(4, 22);
            this.tPMain.Name = "tPMain";
            this.tPMain.Padding = new System.Windows.Forms.Padding(3);
            this.tPMain.Size = new System.Drawing.Size(1226, 641);
            this.tPMain.TabIndex = 0;
            this.tPMain.Text = "Main";
            this.tPMain.UseVisualStyleBackColor = true;
            this.tPMain.Click += new System.EventHandler(this.tPMain_Click);
            // 
            // chbCreateNewFile
            // 
            this.chbCreateNewFile.AutoSize = true;
            this.chbCreateNewFile.Location = new System.Drawing.Point(82, 159);
            this.chbCreateNewFile.Name = "chbCreateNewFile";
            this.chbCreateNewFile.Size = new System.Drawing.Size(139, 17);
            this.chbCreateNewFile.TabIndex = 83;
            this.chbCreateNewFile.Text = "Create New Connection";
            this.chbCreateNewFile.UseVisualStyleBackColor = true;
            this.chbCreateNewFile.CheckedChanged += new System.EventHandler(this.chbCreateNewFile_CheckedChanged);
            // 
            // btnUpdateConnections
            // 
            this.btnUpdateConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateConnections.Enabled = false;
            this.btnUpdateConnections.Location = new System.Drawing.Point(282, 159);
            this.btnUpdateConnections.Name = "btnUpdateConnections";
            this.btnUpdateConnections.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateConnections.TabIndex = 80;
            this.btnUpdateConnections.Text = "Save Connection";
            this.btnUpdateConnections.UseVisualStyleBackColor = true;
            this.btnUpdateConnections.Click += new System.EventHandler(this.btnUpdateConnections_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFalse);
            this.panel1.Controls.Add(this.rbTrue);
            this.panel1.Location = new System.Drawing.Point(82, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 29);
            this.panel1.TabIndex = 78;
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(59, 6);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(50, 17);
            this.rbFalse.TabIndex = 1;
            this.rbFalse.Text = "False";
            this.rbFalse.UseVisualStyleBackColor = true;
            this.rbFalse.CheckedChanged += new System.EventHandler(this.rbFalse_CheckedChanged);
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Checked = true;
            this.rbTrue.Location = new System.Drawing.Point(6, 5);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(47, 17);
            this.rbTrue.TabIndex = 0;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "True";
            this.rbTrue.UseVisualStyleBackColor = true;
            this.rbTrue.CheckedChanged += new System.EventHandler(this.rbTrue_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 77;
            this.label15.Text = "Select File";
            // 
            // cbSelectFile
            // 
            this.cbSelectFile.FormattingEnabled = true;
            this.cbSelectFile.Location = new System.Drawing.Point(82, 13);
            this.cbSelectFile.Name = "cbSelectFile";
            this.cbSelectFile.Size = new System.Drawing.Size(329, 21);
            this.cbSelectFile.TabIndex = 76;
            this.cbSelectFile.SelectedIndexChanged += new System.EventHandler(this.cbSelectFile_SelectedIndexChanged);
            // 
            // btnGenerateProcedure
            // 
            this.btnGenerateProcedure.Location = new System.Drawing.Point(316, 435);
            this.btnGenerateProcedure.Name = "btnGenerateProcedure";
            this.btnGenerateProcedure.Size = new System.Drawing.Size(104, 23);
            this.btnGenerateProcedure.TabIndex = 75;
            this.btnGenerateProcedure.Text = "Gen Proc";
            this.btnGenerateProcedure.UseVisualStyleBackColor = true;
            this.btnGenerateProcedure.Click += new System.EventHandler(this.btnGenerateProcedure_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(316, 397);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(104, 23);
            this.btnData.TabIndex = 74;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnTableDesign
            // 
            this.btnTableDesign.Location = new System.Drawing.Point(316, 368);
            this.btnTableDesign.Name = "btnTableDesign";
            this.btnTableDesign.Size = new System.Drawing.Size(104, 23);
            this.btnTableDesign.TabIndex = 73;
            this.btnTableDesign.Text = "Design";
            this.btnTableDesign.UseVisualStyleBackColor = true;
            this.btnTableDesign.Click += new System.EventHandler(this.btnTableDesign_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(433, 28);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(763, 142);
            this.txtQuery.TabIndex = 72;
            this.txtQuery.Text = "";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(280, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(131, 20);
            this.txtPassword.TabIndex = 69;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(82, 128);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(129, 20);
            this.txtUsername.TabIndex = 67;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(282, 93);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(129, 20);
            this.txtTimeout.TabIndex = 65;
            this.txtTimeout.Text = "25";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(82, 66);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(329, 20);
            this.txtDatabase.TabIndex = 61;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(82, 40);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(329, 20);
            this.txtServer.TabIndex = 59;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Green;
            this.lblMessage.Location = new System.Drawing.Point(432, 174);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(66, 16);
            this.lblMessage.TabIndex = 71;
            this.lblMessage.Text = "Welcome";
            // 
            // pnlSelectCategory
            // 
            this.pnlSelectCategory.Controls.Add(this.rbtnProcedures);
            this.pnlSelectCategory.Controls.Add(this.rbtnTables);
            this.pnlSelectCategory.Location = new System.Drawing.Point(316, 270);
            this.pnlSelectCategory.Name = "pnlSelectCategory";
            this.pnlSelectCategory.Size = new System.Drawing.Size(87, 57);
            this.pnlSelectCategory.TabIndex = 70;
            // 
            // rbtnProcedures
            // 
            this.rbtnProcedures.AutoSize = true;
            this.rbtnProcedures.Location = new System.Drawing.Point(5, 29);
            this.rbtnProcedures.Name = "rbtnProcedures";
            this.rbtnProcedures.Size = new System.Drawing.Size(79, 17);
            this.rbtnProcedures.TabIndex = 1;
            this.rbtnProcedures.TabStop = true;
            this.rbtnProcedures.Text = "Procedures";
            this.rbtnProcedures.UseVisualStyleBackColor = true;
            this.rbtnProcedures.CheckedChanged += new System.EventHandler(this.rbtnProcedures_CheckedChanged);
            // 
            // rbtnTables
            // 
            this.rbtnTables.AutoSize = true;
            this.rbtnTables.Location = new System.Drawing.Point(5, 6);
            this.rbtnTables.Name = "rbtnTables";
            this.rbtnTables.Size = new System.Drawing.Size(57, 17);
            this.rbtnTables.TabIndex = 0;
            this.rbtnTables.TabStop = true;
            this.rbtnTables.Text = "Tables";
            this.rbtnTables.UseVisualStyleBackColor = true;
            this.rbtnTables.CheckedChanged += new System.EventHandler(this.rbtnTables_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Int Security";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Server";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(1121, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstBoxTables
            // 
            this.lstBoxTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBoxTables.FormattingEnabled = true;
            this.lstBoxTables.HorizontalScrollbar = true;
            this.lstBoxTables.Location = new System.Drawing.Point(26, 229);
            this.lstBoxTables.Name = "lstBoxTables";
            this.lstBoxTables.ScrollAlwaysVisible = true;
            this.lstBoxTables.Size = new System.Drawing.Size(284, 368);
            this.lstBoxTables.TabIndex = 56;
            this.lstBoxTables.SelectedIndexChanged += new System.EventHandler(this.lstBoxTables_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(1121, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 55;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Enter Query Below and Click on Run Button";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(316, 241);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 53;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDataGridView.AutoScroll = true;
            this.pnlDataGridView.Controls.Add(this.dgView);
            this.pnlDataGridView.Location = new System.Drawing.Point(426, 219);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(780, 413);
            this.pnlDataGridView.TabIndex = 52;
            // 
            // dgView
            // 
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView.Location = new System.Drawing.Point(7, 9);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgView.Size = new System.Drawing.Size(767, 399);
            this.dgView.TabIndex = 0;
            // 
            // tpGenerateProcedure
            // 
            this.tpGenerateProcedure.Controls.Add(this.btnGenerateList);
            this.tpGenerateProcedure.Controls.Add(this.label14);
            this.tpGenerateProcedure.Controls.Add(this.tbParameterList);
            this.tpGenerateProcedure.Controls.Add(this.tbWhere);
            this.tpGenerateProcedure.Controls.Add(this.tbProcedure);
            this.tpGenerateProcedure.Controls.Add(this.btnReset);
            this.tpGenerateProcedure.Controls.Add(this.btnAddWhereClause);
            this.tpGenerateProcedure.Controls.Add(this.pnlTop);
            this.tpGenerateProcedure.Location = new System.Drawing.Point(4, 22);
            this.tpGenerateProcedure.Name = "tpGenerateProcedure";
            this.tpGenerateProcedure.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenerateProcedure.Size = new System.Drawing.Size(1226, 641);
            this.tpGenerateProcedure.TabIndex = 1;
            this.tpGenerateProcedure.Text = "Procedure";
            this.tpGenerateProcedure.UseVisualStyleBackColor = true;
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateList.Location = new System.Drawing.Point(934, 492);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(90, 25);
            this.btnGenerateList.TabIndex = 52;
            this.btnGenerateList.Text = "GenerateList";
            this.btnGenerateList.UseVisualStyleBackColor = true;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(904, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "List Generated from Store Procedure";
            // 
            // tbParameterList
            // 
            this.tbParameterList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParameterList.Location = new System.Drawing.Point(755, 24);
            this.tbParameterList.Name = "tbParameterList";
            this.tbParameterList.ReadOnly = true;
            this.tbParameterList.Size = new System.Drawing.Size(453, 447);
            this.tbParameterList.TabIndex = 51;
            this.tbParameterList.Text = "";
            // 
            // tbWhere
            // 
            this.tbWhere.Location = new System.Drawing.Point(7, 495);
            this.tbWhere.Name = "tbWhere";
            this.tbWhere.Size = new System.Drawing.Size(733, 50);
            this.tbWhere.TabIndex = 49;
            this.tbWhere.Text = "";
            // 
            // tbProcedure
            // 
            this.tbProcedure.Location = new System.Drawing.Point(7, 220);
            this.tbProcedure.Name = "tbProcedure";
            this.tbProcedure.Size = new System.Drawing.Size(733, 251);
            this.tbProcedure.TabIndex = 48;
            this.tbProcedure.Text = "";
            this.tbProcedure.TextChanged += new System.EventHandler(this.tbProcedure_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 565);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAddWhereClause
            // 
            this.btnAddWhereClause.Location = new System.Drawing.Point(127, 565);
            this.btnAddWhereClause.Name = "btnAddWhereClause";
            this.btnAddWhereClause.Size = new System.Drawing.Size(121, 23);
            this.btnAddWhereClause.TabIndex = 46;
            this.btnAddWhereClause.Text = "Add Where Clause";
            this.btnAddWhereClause.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnLoadTableParameter);
            this.pnlTop.Controls.Add(this.chbSelectAll);
            this.pnlTop.Controls.Add(this.lbxParameters);
            this.pnlTop.Controls.Add(this.btnRemove);
            this.pnlTop.Controls.Add(this.btnGenereateProcedure);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.tbProcedureName);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.tbLength);
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.pnlParameterType);
            this.pnlTop.Controls.Add(this.label10);
            this.pnlTop.Controls.Add(this.tbParameter);
            this.pnlTop.Controls.Add(this.label11);
            this.pnlTop.Controls.Add(this.tbTableName);
            this.pnlTop.Controls.Add(this.pnlProcedureType);
            this.pnlTop.Controls.Add(this.label12);
            this.pnlTop.Controls.Add(this.label13);
            this.pnlTop.Location = new System.Drawing.Point(6, 6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(734, 208);
            this.pnlTop.TabIndex = 4;
            // 
            // btnLoadTableParameter
            // 
            this.btnLoadTableParameter.Location = new System.Drawing.Point(641, 14);
            this.btnLoadTableParameter.Name = "btnLoadTableParameter";
            this.btnLoadTableParameter.Size = new System.Drawing.Size(90, 23);
            this.btnLoadTableParameter.TabIndex = 21;
            this.btnLoadTableParameter.Text = "Load Table";
            this.btnLoadTableParameter.UseVisualStyleBackColor = true;
            this.btnLoadTableParameter.Click += new System.EventHandler(this.btnLoadTableParameter_Click);
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.Location = new System.Drawing.Point(463, 18);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chbSelectAll.TabIndex = 20;
            this.chbSelectAll.Text = "Select All";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            this.chbSelectAll.CheckedChanged += new System.EventHandler(this.chbSelectAll_CheckedChanged);
            // 
            // lbxParameters
            // 
            this.lbxParameters.FormattingEnabled = true;
            this.lbxParameters.Items.AddRange(new object[] {
            "one",
            "Two",
            "Three"});
            this.lbxParameters.Location = new System.Drawing.Point(459, 41);
            this.lbxParameters.Name = "lbxParameters";
            this.lbxParameters.Size = new System.Drawing.Size(272, 154);
            this.lbxParameters.TabIndex = 19;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(363, 176);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnGenereateProcedure
            // 
            this.btnGenereateProcedure.Location = new System.Drawing.Point(187, 176);
            this.btnGenereateProcedure.Name = "btnGenereateProcedure";
            this.btnGenereateProcedure.Size = new System.Drawing.Size(121, 23);
            this.btnGenereateProcedure.TabIndex = 16;
            this.btnGenereateProcedure.Text = "Generate Procedure";
            this.btnGenereateProcedure.UseVisualStyleBackColor = true;
            this.btnGenereateProcedure.Click += new System.EventHandler(this.btnGenereateProcedure_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbProcedureName
            // 
            this.tbProcedureName.Location = new System.Drawing.Point(106, 45);
            this.tbProcedureName.Name = "tbProcedureName";
            this.tbProcedureName.Size = new System.Drawing.Size(347, 20);
            this.tbProcedureName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Procedure Name";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(406, 115);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(47, 20);
            this.tbLength.TabIndex = 14;
            this.tbLength.Text = "50";
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Length";
            // 
            // pnlParameterType
            // 
            this.pnlParameterType.Controls.Add(this.rbtnDecimal);
            this.pnlParameterType.Controls.Add(this.rbtnBit);
            this.pnlParameterType.Controls.Add(this.rbtnDate);
            this.pnlParameterType.Controls.Add(this.rbtnVarchar);
            this.pnlParameterType.Controls.Add(this.rbtnInt);
            this.pnlParameterType.Location = new System.Drawing.Point(106, 141);
            this.pnlParameterType.Name = "pnlParameterType";
            this.pnlParameterType.Size = new System.Drawing.Size(347, 31);
            this.pnlParameterType.TabIndex = 13;
            // 
            // rbtnDecimal
            // 
            this.rbtnDecimal.AutoSize = true;
            this.rbtnDecimal.Location = new System.Drawing.Point(207, 7);
            this.rbtnDecimal.Name = "rbtnDecimal";
            this.rbtnDecimal.Size = new System.Drawing.Size(63, 17);
            this.rbtnDecimal.TabIndex = 4;
            this.rbtnDecimal.TabStop = true;
            this.rbtnDecimal.Text = "Decimal";
            this.rbtnDecimal.UseVisualStyleBackColor = true;
            // 
            // rbtnBit
            // 
            this.rbtnBit.AutoSize = true;
            this.rbtnBit.Location = new System.Drawing.Point(165, 7);
            this.rbtnBit.Name = "rbtnBit";
            this.rbtnBit.Size = new System.Drawing.Size(37, 17);
            this.rbtnBit.TabIndex = 3;
            this.rbtnBit.TabStop = true;
            this.rbtnBit.Text = "Bit";
            this.rbtnBit.UseVisualStyleBackColor = true;
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(111, 7);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(48, 17);
            this.rbtnDate.TabIndex = 2;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            // 
            // rbtnVarchar
            // 
            this.rbtnVarchar.AutoSize = true;
            this.rbtnVarchar.Location = new System.Drawing.Point(45, 7);
            this.rbtnVarchar.Name = "rbtnVarchar";
            this.rbtnVarchar.Size = new System.Drawing.Size(62, 17);
            this.rbtnVarchar.TabIndex = 1;
            this.rbtnVarchar.TabStop = true;
            this.rbtnVarchar.Text = "Varchar";
            this.rbtnVarchar.UseVisualStyleBackColor = true;
            // 
            // rbtnInt
            // 
            this.rbtnInt.AutoSize = true;
            this.rbtnInt.Location = new System.Drawing.Point(3, 7);
            this.rbtnInt.Name = "rbtnInt";
            this.rbtnInt.Size = new System.Drawing.Size(36, 17);
            this.rbtnInt.TabIndex = 0;
            this.rbtnInt.TabStop = true;
            this.rbtnInt.Text = "int";
            this.rbtnInt.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Type";
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(106, 115);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(247, 20);
            this.tbParameter.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "paremeter";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(106, 77);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(347, 20);
            this.tbTableName.TabIndex = 11;
            // 
            // pnlProcedureType
            // 
            this.pnlProcedureType.Controls.Add(this.rbtnDelete);
            this.pnlProcedureType.Controls.Add(this.rbtnInsert);
            this.pnlProcedureType.Controls.Add(this.rbtnUpdate);
            this.pnlProcedureType.Controls.Add(this.rbtnLoad);
            this.pnlProcedureType.Location = new System.Drawing.Point(103, 7);
            this.pnlProcedureType.Name = "pnlProcedureType";
            this.pnlProcedureType.Size = new System.Drawing.Size(247, 26);
            this.pnlProcedureType.TabIndex = 0;
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Location = new System.Drawing.Point(181, 3);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(56, 17);
            this.rbtnDelete.TabIndex = 3;
            this.rbtnDelete.TabStop = true;
            this.rbtnDelete.Text = "Delete";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            // 
            // rbtnInsert
            // 
            this.rbtnInsert.AutoSize = true;
            this.rbtnInsert.Location = new System.Drawing.Point(124, 3);
            this.rbtnInsert.Name = "rbtnInsert";
            this.rbtnInsert.Size = new System.Drawing.Size(51, 17);
            this.rbtnInsert.TabIndex = 2;
            this.rbtnInsert.TabStop = true;
            this.rbtnInsert.Text = "Insert";
            this.rbtnInsert.UseVisualStyleBackColor = true;
            this.rbtnInsert.CheckedChanged += new System.EventHandler(this.rbtnInsert_CheckedChanged);
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.AutoSize = true;
            this.rbtnUpdate.Location = new System.Drawing.Point(58, 3);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(60, 17);
            this.rbtnUpdate.TabIndex = 1;
            this.rbtnUpdate.TabStop = true;
            this.rbtnUpdate.Text = "Update";
            this.rbtnUpdate.UseVisualStyleBackColor = true;
            this.rbtnUpdate.CheckedChanged += new System.EventHandler(this.rbtnUpdate_CheckedChanged);
            // 
            // rbtnLoad
            // 
            this.rbtnLoad.AutoSize = true;
            this.rbtnLoad.Location = new System.Drawing.Point(3, 3);
            this.rbtnLoad.Name = "rbtnLoad";
            this.rbtnLoad.Size = new System.Drawing.Size(49, 17);
            this.rbtnLoad.TabIndex = 0;
            this.rbtnLoad.TabStop = true;
            this.rbtnLoad.Text = "Load";
            this.rbtnLoad.UseVisualStyleBackColor = true;
            this.rbtnLoad.CheckedChanged += new System.EventHandler(this.rbtnLoad_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Table Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Procedure Type";
            // 
            // FormShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 683);
            this.Controls.Add(this.panelMain);
            this.Name = "FormShowData";
            this.Text = "Show Data Base";
            this.Load += new System.EventHandler(this.FormShowData_Load);
            this.panelMain.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tPMain.ResumeLayout(false);
            this.tPMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSelectCategory.ResumeLayout(false);
            this.pnlSelectCategory.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.tpGenerateProcedure.ResumeLayout(false);
            this.tpGenerateProcedure.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlParameterType.ResumeLayout(false);
            this.pnlParameterType.PerformLayout();
            this.pnlProcedureType.ResumeLayout(false);
            this.pnlProcedureType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabConnection;
        private System.Windows.Forms.TabPage tPMain;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnTableDesign;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlSelectCategory;
        private System.Windows.Forms.RadioButton rbtnProcedures;
        private System.Windows.Forms.RadioButton rbtnTables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstBoxTables;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TabPage tpGenerateProcedure;
        private System.Windows.Forms.RichTextBox tbWhere;
        private System.Windows.Forms.RichTextBox tbProcedure;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddWhereClause;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.CheckedListBox lbxParameters;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnGenereateProcedure;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbProcedureName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlParameterType;
        private System.Windows.Forms.RadioButton rbtnDecimal;
        private System.Windows.Forms.RadioButton rbtnBit;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnVarchar;
        private System.Windows.Forms.RadioButton rbtnInt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Panel pnlProcedureType;
        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.RadioButton rbtnInsert;
        private System.Windows.Forms.RadioButton rbtnUpdate;
        private System.Windows.Forms.RadioButton rbtnLoad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbSelectAll;
        private System.Windows.Forms.Button btnLoadTableParameter;
        private System.Windows.Forms.Button btnGenerateProcedure;
        private System.Windows.Forms.Button btnGenerateList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox tbParameterList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSelectFile;
        private System.Windows.Forms.CheckBox chbCreateNewFile;
        private System.Windows.Forms.Button btnUpdateConnections;

    }
}

