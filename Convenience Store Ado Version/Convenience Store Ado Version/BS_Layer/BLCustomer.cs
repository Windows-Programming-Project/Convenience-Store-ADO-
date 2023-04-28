using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
     class BLCustomer
    {
        DBMain db = null;
        public BLCustomer()
        {
            db = new DBMain();
        }
        public DataSet TakeCustomer()
        {
            return db.ExecuteQueryDataSet("select * from Customer", CommandType.Text);
        }
        public bool AddCustomer(string cID, string cName, float TotalPay,string cPhone,ref string err)
        {
            string sqlString = "Insert Into Customer Values(" + "N'" +
            cID + "',N'" +
            cName + "'," +
            TotalPay + ",N'"+
            cPhone + 
            "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateCustomer(string cID, string cName, float TotalPay, string cPhone, ref string err)
        {
            string sqlString = "UPDATE Customer SET " +
                               "cName = N'" + cName + "', " +
                               "cTotalpay = '" +TotalPay + "', " +
                               "cPhoneNum = N'" + cPhone + "', " +
                               "WHERE cID = N'" + cID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteEmployee(string cID, ref string err)
        {
            string sqlString = "DELETE FROM Customer WHERE cID = N'" + cID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
