using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLStock
    {
        DBMain db = null;
        public BLStock()
        {
            db = new DBMain();
        }
        public DataSet TakeStock()
        {
            return db.ExecuteQueryDataSet("select * from Stock", CommandType.Text);
        }
        public bool AddStock(string batchID, DateTime imDate, int amountofProduct,string sID, ref string err)
        {
            string sqlString = "Insert Into Stock Values(" + "'" +
            batchID + "',N'" +
            imDate + "',N'" +
            amountofProduct + "',N'" +
            sID + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteStock(ref string err, string batchID)
        {
            string sqlString = "Delete From Stock Where batchID='" + batchID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateStock(string batchID, DateTime imDate, int amountofProduct,string sID, ref string err)
        {
            string sqlString = "Update Stock Set imDate=N'" + imDate +
                "', amountofProduct=N'" + amountofProduct +
                "', sID=N'" + sID +
                "' Where batchID='" + batchID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
