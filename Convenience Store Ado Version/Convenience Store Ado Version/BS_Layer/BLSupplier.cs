using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLSupplier
    {
        DBMain db = null;
        public BLSupplier()
        {
            db = new DBMain();
        }
        public DataSet TakeSupplier()
        {
            return db.ExecuteQueryDataSet("select * from Supplier", CommandType.Text);
        }
        public bool AddSupplier(string sID, string mID, string sName, ref string err)
        {
            string sqlString = "Insert Into Supplier Values(" + "'" +
            sID + "',N'" +
            mID + "',N'" +
            sName + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteSupplier(ref string err, string sID)
        {
            string sqlString = "Delete From Supplier Where sID='" + sID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateSupplier(string sID, string mID, string sName, ref string err)
        {
            string sqlString = "Update Supplier Set mID=N'" + mID +
                "', sName=N'" + sName +
                "' Where sID='" + sID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
