using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDataBase.Data
{

    public static class StaticClass
    {
        public static List<KeyValuePair<int, string>> listStudyCategory = new List<KeyValuePair<int, string>>();
        public static List<KeyValuePair<int, string>> listMainCategory = new List<KeyValuePair<int, string>>();
        public static List<KeyValuePair<int, string>> listSubCategory = new List<KeyValuePair<int, string>>();

        public static List<KeyValuePair<string, string>> listProcedures = new List<KeyValuePair<string, string>>();
        public static DataSet dsTableDesign = new DataSet();

       

        #region"Add Update Query"
        public static void ExceuteQuery(string query, List<SqlParameter> sqlParam)
        {

            var connection = new SqlConnection(connnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;
            foreach (var param in sqlParam)
            {
                command.Parameters.Add(param);
            }
            command.ExecuteNonQuery();

        }
        public static void ExceuteQuery(string query, bool WithoutParameter)
        {

            var connection = new SqlConnection(connnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;

            command.ExecuteNonQuery();

        }
        public static void ExceuteQuery(string query)
        {
            var connection = new SqlConnection(connnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        #endregion
        #region"LoadData"
        public static DataSet LoadData(string query, List<SqlParameter> sqlParam)
        {
            DataSet dt = new DataSet();
            var connection = new SqlConnection(connnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;
            foreach (var param in sqlParam)
            {
                command.Parameters.Add(param);
            }

            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(command);
            objSqlDataAdapter.Fill(dt);
            connection.Close();


            return dt;
        }
        public static DataSet LoadData(string query, bool WithoutParameter)
        {
            DataSet dt = new DataSet();
            var connection = new SqlConnection(connnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;


            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(command);
            objSqlDataAdapter.Fill(dt);
            connection.Close();


            return dt;
        }
        public static DataSet LoadData(string query)
        {
            DataSet dt = new DataSet();
            var connection = new SqlConnection(connnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;


            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(command);
            objSqlDataAdapter.Fill(dt);
            connection.Close();
            return dt;
        }
        #endregion
//        public static string connnectionString = "Data Source=.;Initial Catalog=MCQ_Database;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        public static string connnectionString = "Data Source=69.162.125.10;Initial Catalog=broadsol_Main;Integrated Security=false;Connect Timeout=60;User ID=broadsol_MainUser;Password=broad786SolUtions";
       // public static string server = "69.162.125.10";
        //public static string database = "broadsol_Main";
        //public static string integratedSecurity = "false";
        //public static string timeout = "60";
        //public static string userId = "broadsol_MainUser";
        //public static string password = "broad786SolUtions";

        public static void updateConnectionString(string ServerName, string initialCatelog, string integratedSecurity, string timeout, string userId, string password )
        {
            connnectionString = "Data Source=" + ServerName + ";Initial Catalog=" + initialCatelog + ";Integrated Security=" + integratedSecurity + ";Connect Timeout=" + timeout + ";User ID=" + userId + ";Password=" + password;
        }
        
    }
}
