using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLEmployeeLate
    {
        DBMain db = null;
        public BLEmployeeLate()
        {
            db = new DBMain();
        }
        public DataSet TakeEmployeeLate()
        {
            return db.ExecuteQueryDataSet("select * from EmployeeLate", CommandType.Text);
        }
        public bool AddEmployeeLate(string eID, DateTime LateDate, TimeSpan StartTime, TimeSpan EndTime, string shID, ref string err)
        {
            string sqlString = "Insert Into EmployeeLate Values(" + "'" +
            eID + "',N'" +
            LateDate.Date + "',N'" +
            StartTime + "',N'" +
            EndTime + "',N'" +
            shID + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteEmployeeLate(string eID, string shID,ref string err)
        {
            string sqlString = "Delete From EmployeeLate Where eID=N'" + eID + "' AND shID=N'" + shID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateEmployeeLate(string eID, DateTime LateDate, TimeSpan StartTime, TimeSpan EndTime, string shID, ref string err)
        {
            string sqlString = "Update EmployeeLate Set LateDate='" + LateDate.Date +
            "', StartTime='" + StartTime + "', EndTime=N'" + EndTime +
               "' Where eID=N'" + eID + "' AND shID=N'" + shID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
