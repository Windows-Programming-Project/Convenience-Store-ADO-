using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Convenience_Store_Ado_Version.DB_Layer;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLInvoice
    {
        DBMain db = null;
        public BLInvoice()
        {
            db = new DBMain();
        }
        public DataSet TakeInvoice()
        {
            return db.ExecuteQueryDataSet("select * from Invoice", CommandType.Text);
        }
        public bool AddInvoice(string IDI, string IDE, string IDC, DateTime iDate, float iTotal, ref string err)
        {
            string sqlString = "Insert Into Invoice Values(" + "'" +
            IDI + "',N'" +
            IDE + "',N'" +
            IDC + "',N'" +
            iDate+ "',N'" +
            iTotal+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteInvoice(ref string err, string IDI, string IDE, string IDC)
        {
            string sqlString = "Delete From Invoice Where iID=N'" + IDI + "' AND eID=N'"+IDE+"' AND cID=N'"+IDC+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateInvoice(string IDI, string IDE, string IDC, DateTime iDate, float iTotal, ref string err)
        {
            string sqlString = "Update Invoice Set iDate='" + iDate +
            "', iTotalpay='" + iTotal + "', eID=N'" + IDE + "', cID=N'" + IDC +
               "' Where iID=N'" + IDI + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
