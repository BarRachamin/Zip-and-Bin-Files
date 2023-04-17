using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class EProductsCM
    {
        public List< ProductsCM> ProductsList = new List<ProductsCM>();


        public async void getAllProductFromDBSQLToDBCosmos()
        {
            
            ProductsList = MainManager.Instance.ProductSql.getAllProductFromDB();
          
            Dal.ConnectionCosmos connectionCosmos = new Dal.ConnectionCosmos();

            await connectionCosmos.GetStartedDemoAsync(ProductsList);
        }

    }
}
