using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLRank
    {
        DBMain db = null;
        public BLRank()
        {

            db = new DBMain();

        }
        public DataSet TakeRank()
        {
            return db.ExecuteQueryDataSet("select * from Rank", CommandType.Text);
        }
        public bool AddRank(string rName, float rDiscount, ref string err)
        {
            string sqlString = "Insert Into Rank Values(" + "'" +
            rName + "',N'" +
            rDiscount + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteRank(ref string err, string rName)
        {
            string sqlString = "Delete From Rank Where rName='" + rName + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateRank(string rName, float rDiscount, ref string err)
        {
            string sqlString = "Update Rank Set rDiscount=N'" + rDiscount +
                "' Where rName='" + rName + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
