using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class EProductSql
    {
        //Global Dictionary
        public List<ProductsCM> ProductsList = new List<ProductsCM>();



        //get all products
        public List< ProductsCM> getAllProductFromDB()
        {
            DataSql.GetProductsSql Product = new DataSql.GetProductsSql();
            ProductsList = (List<ProductsCM>)Product.SendSqlQueryToReadProductsFromDB();
            return ProductsList;
        }

    }
}
