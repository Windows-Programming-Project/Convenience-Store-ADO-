using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLShift
    {
        DBMain db = null;
        public BLShift()
        {

            db = new DBMain();

        }
        public DataSet TakeShift()
        {
            return db.ExecuteQueryDataSet("select * from Shift", CommandType.Text);
        }
        public bool AddShift(string shID, TimeSpan StartTime, TimeSpan EndTime, ref string err)
        {
            string sqlString = "Insert Into Shift Values(" + "'" +
            shID + "',N'" +
            StartTime + "',N'" +
            EndTime + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteShift(ref string err, string shID)
        {
            string sqlString = "Delete From Shift Where shID='" + shID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateShift(string shID, TimeSpan StartTime, TimeSpan EndTime, ref string err)
        {
            string sqlString = "Update Shift Set StartTime=N'" + StartTime +
                "', EndTime=N'" + EndTime +
                "' Where shID='" + shID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
