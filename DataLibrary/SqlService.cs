using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public static class SqlService
    {
        static SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MorseCodeDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public static int SaveTranslation(string text, string morse)
        {
            int id = -1;
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "SaveTranslation";

                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@id";
                sqlParameter.Direction = ParameterDirection.Output;
                sqlParameter.SqlDbType = SqlDbType.Int;
                sqlCommand.Parameters.Add(sqlParameter);  
                
                AddVarCharParam(sqlCommand, "@text", 50, text);
                AddVarCharParam(sqlCommand, "@morse", 50, morse);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected == 1)
                    id = (int)sqlCommand.Parameters["@id"].Value;
            }

            sqlConnection.Close();
            return id;
        }

        public static List<TranslationModel> ReadAllTranslations()
        {
            sqlConnection.Open();
            TranslationModel retrievedTranslation = null;
            List<TranslationModel> contacts = new List<TranslationModel>();

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "select * from Translations";

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        retrievedTranslation = new TranslationModel();
                        retrievedTranslation.Id = (int)reader["Id"];
                        retrievedTranslation.Text = reader["Text"].ToString();
                        retrievedTranslation.Morse = reader["Morse"].ToString();
                        contacts.Add(retrievedTranslation);
                    }
                }
            }           

            sqlConnection.Close();
            return contacts; // Remeber to modify when done!!!
        }

        private static void AddVarCharParam(SqlCommand cmd, string paramName, int paramSize, string paramValue)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = paramName;
            sqlParameter.SqlDbType = SqlDbType.NVarChar;
            sqlParameter.Direction = ParameterDirection.Input;
            sqlParameter.Size = paramSize;
            sqlParameter.Value = paramValue;
            cmd.Parameters.Add(sqlParameter);
        }

    }
}
