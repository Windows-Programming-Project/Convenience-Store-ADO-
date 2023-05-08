using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Convenience_Store_Ado_Version.BS_Layer
{
    
    class BLEmployee
    {
        DBMain db = null;
        public BLEmployee()
        {
            db = new DBMain();
        }
        public DataSet TakeEmployee()
        {
            return db.ExecuteQueryDataSet("select * from Employee", CommandType.Text);
        }
        public bool AddEmployee(string EID, string EName, DateTime EDateOfBirth, int EGender,string EPhone,string EAddress,string EPosition,float ESalary, ref string err)
        {
            string sqlString = "Insert Into Employee Values(" + "N'" +
            EID + "',N'" +
            EName + "','"+
            EDateOfBirth + "'," +
            EGender + ",N'" +
            EPhone + "',N'" +
            EAddress + "',N'" +
            EPosition + "','" +
            ESalary +
            "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateEmployee(string EID, string EName, DateTime EDateOfBirth, int EGender, string EPhone, string EAddress, string EPosition, float ESalary, ref string err)
        {
            string sqlString = "UPDATE Employee SET " +
                               "eName = N'" + EName + "', " +
                               "eBirthdate = '" + EDateOfBirth + "', " +
                               "eGender = " + EGender + ", " +
                               "ePhone = N'" + EPhone + "', " +
                               "eAddress = N'" + EAddress + "', " +
                               "ePosition = N'" + EPosition + "', " +
                               "eSalary = " + ESalary.ToString() + " " +
                               "WHERE eID = N'" + EID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteEmployee(string EID, ref string err)
        {
            string sqlString = "DELETE FROM Employee WHERE eID = N'" + EID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
