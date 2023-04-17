using App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataSql
{
    public class GetProductsSql
    {
        public List<ProductsCM> ReadFromDb(SqlDataReader reader)
        {
            List<ProductsCM> ProductsList = new List<ProductsCM>();

            int CountIdToString = 0;

            //Clear Hashtable Before Inserting Information From Sql Server
            ProductsList.Clear();

            while (reader.Read())
            {
                
                ProductsCM product = new ProductsCM();

                product.ID = CountIdToString.ToString();
                product.ProductID = reader.GetInt32(0);
                product.ProductName = reader.GetString(1);
                product.UnitPrice = reader.GetDecimal(2);
                product.OrderId = reader.GetInt32(3);

                ProductsList.Add( product );
                CountIdToString++;
            }
            return ProductsList;
        }


        public object SendSqlQueryToReadProductsFromDB()
        {
            string SqlQuery = "Select P.ProductID,P.ProductName,P.UnitPrice,OD.OrderID from Products as P \r\ninner join [Order Details] as OD on P.ProductID=OD.ProductID\r\n";
            object retDict = null;
            retDict = Dal.ConnectionSql.StartReadFromDB(SqlQuery, ReadFromDb);
            return retDict;
        }
    }
}
