using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using m = LastExam.Model;

namespace LastExam.DataBaseWebHelper
{
    public class DataBase
    {
        const string database = "Parcial";
        const string server = "localhost";
        SqlConnection connection = new SqlConnection($"Data Source={server};Initial Catalog={database};Integrated Security=True");

        public DataTable GetCards()
        {
            return this.Fill("[dbo].[spGetCards]", null);
        }

        //Method to save a new database
        public void SaveCard(m.Card card)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@Name", card.Name),
                new SqlParameter("@CardNumber", card.CardNumber),
                new SqlParameter("@ExpirationDate", card.ExperationDate),
                new SqlParameter("@CVV", card.CVV),
                new SqlParameter("@Banco", card.Banco),
                new SqlParameter("@Color", card.Color),
                new SqlParameter("@Emisor", card.Emisor)

            };
            this.ExecuteQuery("[dbo].[spSaveCard]", param);
        }

        public DataTable Fill(string storedProcedure, List<SqlParameter> param)
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    if (param != null)
                    {
                        foreach (SqlParameter p in param)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }

                    DataTable ds = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Method to create or insert something in databeses
        public void ExecuteQuery(string storedProcedure, List<SqlParameter> param)
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    if (param != null)
                    {
                        foreach (SqlParameter p in param)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}