﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LenelTA
{
    class _3_GetSQLData_SnapLake
    {
        public void GetSQLData_SnapLake()
        {
            string ConnString = "Data Source=10.129.16.61; Initial Catalog=LenelTA ;User ID=LenelTA ;Password=Commander!1";

            string QueryString = "select * from [LenelTA].[dbo].[301_All_Critical_Records_SnapLake] order by [Access_Date_UTC], [Access_Time_UTC]";

            SqlConnection SqlCon = new SqlConnection();

            DataSet DSet_SnapLake = new DataSet();

            try
            {
                SqlDataAdapter SqlDat = new SqlDataAdapter(QueryString, ConnString);
                SqlDat.SelectCommand.CommandTimeout = 0;

                SqlCommandBuilder SqlComm = new SqlCommandBuilder(SqlDat);

                SqlDat.Fill(DSet_SnapLake);

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

                if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Database Connection is closed");
                }
            }
        }
    }
}
