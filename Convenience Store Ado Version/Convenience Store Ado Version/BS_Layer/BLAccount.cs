using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLAccount
    {
        DBMain db = null;
        public BLAccount()
        {
            db = new DBMain();
        }
        public DataSet TakeAccount()
        {
            return db.ExecuteQueryDataSet("select * from Account", CommandType.Text);
        }
        public bool AddAccount(string aUsername, string aPassword, string eID, string aEmail, int Active, ref string err)
        {
            string sqlString = "INSERT INTO Account (aUsername, aPassword, eID, aEmail, Active) VALUES (N'" +
                                aUsername + "', N'" +
                                aPassword + "', N'" +
                                eID + "', N'" +
                                aEmail + "', " +
                                Active.ToString() + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateAccount(string aUsername, string aPassword, string eID, string aEmail, int Active, ref string err)
        {
            string sqlString = "UPDATE Account SET " +
                               "aPassword = '" + aPassword + "', " +
                               "eID = '" + eID + "', " +
                               "aEmail = '" + aEmail + "', " +
                               "Active = " + Active +
                               " WHERE aUsername = '" + aUsername + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteAccount(string aUsername, ref string err)
        {
            string sqlString = "DELETE FROM Account WHERE aUsername = '" + aUsername + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}
