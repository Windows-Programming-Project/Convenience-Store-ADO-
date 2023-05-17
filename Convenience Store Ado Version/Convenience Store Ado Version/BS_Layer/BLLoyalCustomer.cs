using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
     class BLLoyalCustomer
    {
        DBMain db = null;
        public BLLoyalCustomer()
        {
            db = new DBMain();
        }
        public DataSet TakeCustomer()
        {
            return db.ExecuteQueryDataSet("select * from LoyalCustomer", CommandType.Text);
        }
        public bool AddCustomer(string cID, string cName,string cPhoneNum,string rName,ref string err)
        {
            string sqlString = "Insert Into LoyalCustomer Values(" + "N'" +
            cID + "',N'" +
            cName + "',NULL," +
            cPhoneNum + ",N'" +
            rName + 
            "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateCustomer(string cID, string cName, string cPhoneNum,string rName, ref string err)
        {
            string sqlString = "UPDATE LoyalCustomer SET " +
                               "cName = N'" + cName + "', " +
                               "cPhoneNum = N'" + cPhoneNum + "', " +
                               "rName = N'" + rName + "' " +
                               "WHERE cID = N'" + cID + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteCustomer(string cID, ref string err)
        {
            string sqlString = "DELETE FROM LoyalCustomer WHERE cID = N'" + cID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
