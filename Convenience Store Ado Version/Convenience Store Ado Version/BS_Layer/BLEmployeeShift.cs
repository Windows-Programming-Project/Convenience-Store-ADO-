using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLEmployeeShift
    {
        DBMain db = null;
        public BLEmployeeShift()
        {
            db = new DBMain();
        }
        public DataSet TakeEmployeeShift()
        {
            return db.ExecuteQueryDataSet("select * from Employee_Shift", CommandType.Text);
        }
        public bool AddEmployeeShift(string eID, string shID, ref string err)
        {
            string sqlString = "Insert Into Employee_Shift Values(" + "'" +
                eID + "',N'" +
                shID + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteEmployeeShift(string eID,string shID, ref string err)
        {
            string sqlString = "Delete From Employee_Shift Where eID='" + eID + "' AND shID=N'" + shID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
