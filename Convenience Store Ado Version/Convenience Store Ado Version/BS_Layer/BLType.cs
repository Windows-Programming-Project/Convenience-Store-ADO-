using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLType
    {
        DBMain db = null;
        public BLType()
        {
            db = new DBMain();
        }
        public DataSet TakeType()
        {
            return db.ExecuteQueryDataSet("select * from Type", CommandType.Text);
        }
        public bool AddType(string tID, string tName, ref string err)
        {
            string sqlString = "Insert Into Type Values(" + "'" +
            tID + "',N'" +
            tName  + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteType(ref string err, string tID)
        {
            string sqlString = "Delete From Type Where tID='" + tID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateType(string tID, string tName, ref string err)
        {
            string sqlString = "Update Type Set tName=N'" + tName +
                "' Where tID='" + tID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
