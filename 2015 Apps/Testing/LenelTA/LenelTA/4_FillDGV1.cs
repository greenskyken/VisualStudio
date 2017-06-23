using System;
using System.Data.SqlClient;
using System.Data;

namespace LenelTA
{
    class FillDGV1
    {
        public void GetSQLData()
        {
            string ConnString = "Data Source=10.25.16.61;Initial Catalog=200_Areas;Persist Security Info=True;User ID=sa;Password=Commander!";

            string QueryString = "select * from 200_areas";

            try
            {
                SqlConnection SqlCon = new SqlConnection();

                SqlDataAdapter SqlDat = new SqlDataAdapter(QueryString, ConnString);
                SqlDat.SelectCommand.CommandTimeout = 0;

                SqlCommandBuilder SqlComm = new SqlCommandBuilder(SqlDat);

                DataSet DSet = new DataSet();

                SqlDat.Fill(DSet);
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.WriteLine("Completed");
            }
        }
    }
}