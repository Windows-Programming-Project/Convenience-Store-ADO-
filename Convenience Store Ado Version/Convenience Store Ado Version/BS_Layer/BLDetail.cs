using Convenience_Store_Ado_Version.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLDetail
    {
        DBMain db = null;
        public BLDetail()
        {
            db = new DBMain();
        }
        public DataSet TakeDetail()
        {
            return db.ExecuteQueryDataSet("select * from Detail", CommandType.Text);
        }
        public bool AddDetail(string iID, string pID, int dAmount, float dPrice, ref string err)
        {
            string sqlString = "Insert Into Detail Values(" + "'" +
            iID + "',N'" +
            pID + "',N'" +
            dAmount + "',N'" +
            dPrice + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteDetail(ref string err, string iID, string pID)
        {
            string sqlString = "Delete From Detail Where iID='" + iID + "' AND pID='"+pID+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateDetail(string iID, string pID, int dAmount, float dPrice, ref string err)
        {
            string sqlString = "Update Detail Set dAmount='" + dAmount +
                "', dPrice='" + dPrice + 
                "' Where iID='" + iID + "' AND pID='" + pID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
