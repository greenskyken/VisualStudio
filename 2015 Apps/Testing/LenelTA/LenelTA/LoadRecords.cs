using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LenelTA
{
    class LoadRecords
    {
        public void LoadAreaRecords()
        {
            _4_GetSQL_Areas GetData_Areas = new _4_GetSQL_Areas();
            GetData_Areas.GetSQL_Areas();
        }

        public void LoadSnapRecords()
        {
            _3_GetSQLData_SnapLake GetData_SnapLake = new _3_GetSQLData_SnapLake();
            GetData_SnapLake.GetSQLData_SnapLake();
        }

        public void LoadVictorRecords()
        {
            _2_GetSQLData_Victor GetData_Victor = new _2_GetSQLData_Victor();
            GetData_Victor.GetSQLData_Victor();
        }
    }
}
