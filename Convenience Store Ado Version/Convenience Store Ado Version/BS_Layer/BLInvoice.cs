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
        public bool AddInvoice(string IDI, string IDE, string IDC, DateTime iDate, float iTotalpay,float iFinalTotalpay, ref string err)
        {
            string sqlString = "Insert Into Invoice Values(" + "'" +
            IDI + "',N'" +
            IDE + "',N'" +
            IDC + "',N'" +
            iDate+ "',N'" +
            iTotalpay + "',N'" +
            iFinalTotalpay +"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteInvoice(ref string err, string IDI)
        {
            string sqlString = "Delete From Invoice Where iID=N'" + IDI +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateInvoice(string IDI, string IDE, string IDC, DateTime iDate, float iTotalpay,float iFinalTotalpay, ref string err)
        {
            string sqlString = "Update Invoice Set eID='" + IDE +
            "', cID='" + IDC + "', iDate=N'" + iDate + "', iTotalPay=N'" + iTotalpay + "', iFinalTotalpay=N'" + iFinalTotalpay +
               "' Where iID=N'" + IDI + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
