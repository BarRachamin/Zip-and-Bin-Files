using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Model
{
    public class ProductsCM
    {
        [JsonProperty(PropertyName = "id")]

        public string ID { get; set; }
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int OrderId { get; set; }

        public decimal UnitPrice { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
