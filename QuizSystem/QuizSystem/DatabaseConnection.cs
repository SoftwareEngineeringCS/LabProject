using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuizSystem
{
    /// <summary>
    /// DataBase Connection Class in which we have to make some Functions to Handle
    /// Sql Data Server to Stroe Data and Manage Data
    /// </summary>
    class DatabaseConnection
    {
        private static DatabaseConnection instance;
        public String ConnectionString;
        private SqlConnection connection;

        /// <summary>
        /// Instance of Database Connection
        /// </summary>
        /// <returns> Data connection State</returns>
        public static DatabaseConnection getInstance()
        {
            if (instance == null)
                instance = new DatabaseConnection();
            return instance;
        }
        /// <summary>
        /// Constructor with no Parameters
        /// </summary>
        private DatabaseConnection()
        {

        }
        /// <summary>
        /// It connects Database Connection 
        /// </summary>
        /// <returns>Connection State</returns>
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(ConnectionString);
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            return connection;
        }
        /// <summary>
        /// Read Data From Database
        /// </summary>
        /// <param name="commnadText"> Connection</param>
        /// <returns> reader </returns>
        public SqlDataReader getData(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText,connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// Get Data List From Database
        /// </summary>
        /// <param name="commnadText"></param>
        /// <returns> Data list</returns>
        public SqlDataAdapter getListData(String commnadText)
        {
            connection = getConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(commnadText, connection);
            
            return cmd;
        }

        public int counter(string cmd)
        {
            connection = getConnection();
            SqlCommand sa = new SqlCommand(cmd, connection);
            int n = int.Parse(sa.ExecuteScalar().ToString());
            return n;
        }
        /// <summary>
        ///  Function to execute Query 
        /// </summary>
        /// <param name="commnadText"> String Statement</param>
        /// <returns>result Statement</returns>
        public int exectuteQuery(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText,connection);
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        
        /// <summary>
        /// This will Close Database Connection
        /// </summary>
        public void closeConnection()
        {
            if (connection != null)
                connection.Close();
           
           
        }
    }
}
