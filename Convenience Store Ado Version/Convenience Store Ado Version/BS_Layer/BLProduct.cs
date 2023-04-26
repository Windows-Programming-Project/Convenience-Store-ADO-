using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Convenience_Store_Ado_Version.DB_Layer;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Convenience_Store_Ado_Version.BS_Layer
{
    class BLProduct
    {
        DBMain db = null;
        public BLProduct()
        {
            db = new DBMain();
        }
        public DataSet TakeProduct()
        {
            return db.ExecuteQueryDataSet("select * from Product", CommandType.Text);
        }
        public bool AddProduct(string pID, string pName, float pPrice, string tID, string batchID, ref string err)
        {
            string sqlString = "Insert Into Product Values(" + "'" +
            pID    + "',N'" +
            pName  + "',N'" +
            pPrice + "',N'" +
            tID    + "',N'" +
            batchID+ "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteProduct(ref string err, string pID, string tID, string batchID)
        {
            string sqlString = "Delete From Product Where pID='" + pID + "' AND tID='"+tID+"' AND batchID='"+batchID+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateProduct(string pID, string pName, float pPrice, string tID, string batchID, ref string err)
        {
            string sqlString = "Update Product Set pName=N'" + pName +
                "', pPrice='" + pPrice + "', tID='" + tID + "', batchID='" + batchID +
                "' Where pID=N'" + pID +  "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
