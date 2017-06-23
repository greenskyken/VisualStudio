using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace LenelTA
{
    class _4_GetSQL_Areas
    {
        public void GetSQL_Areas()
        {
            string ConnString = "Data Source=10.129.16.61; Initial Catalog=LenelTA ;User ID=LenelTA ;Password=Commander!1";

            string QueryString = "select * from [LenelTA].[dbo].[200_Areas]";

            SqlConnection SqlCon = new SqlConnection();

            DataSet DSet_Areas = new DataSet();

            try
            {
                SqlDataAdapter SqlDat = new SqlDataAdapter(QueryString, ConnString);
                SqlDat.SelectCommand.CommandTimeout = 0;

                SqlCommandBuilder SqlComm = new SqlCommandBuilder(SqlDat);

                SqlDat.Fill(DSet_Areas);

                SqlCon.Close();

                if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Database Connection is closed");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());

                SqlCon.Close();

                if (SqlCon.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Database Connection is closed");
                }
            }
        }
    }
}
