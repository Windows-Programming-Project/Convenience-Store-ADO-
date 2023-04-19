using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convenience_Store_Ado_Version.DB_Layer;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLManuafacture
    {
        DBMain db = null;
        public BLManuafacture()
        {

            db = new DBMain();

        }
        public DataSet TakeManuafacture()
        {
            return db.ExecuteQueryDataSet("select * from Manuafacture", CommandType.Text);
        }
        public bool AddManuafacture(string mID, string mName,string mLocation, ref string err)
        {
            string sqlString = "Insert Into Manuafacture Values(" + "'" +
            mID + "',N'" +
            mName + "',N'" +
            mLocation + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteManuafacture(ref string err, string mID)
        {
            string sqlString = "Delete From Manuafacture Where mID='" + mID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateManuafacture(string mID, string mName,string mLocation, ref string err)
        {
            string sqlString = "Update Manuafacture Set mName=N'" +mName + 
                "', mLocation=N'"+mLocation+
                "' Where mID='" + mID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
