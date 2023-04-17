using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class MainManager
    {
        private MainManager() { Init(); }

        private static readonly MainManager _Instance = new MainManager();
        public static MainManager Instance { get { return _Instance; } }

        public EProductSql ProductSql { get; set; }
         public EProductsCM ProductCM { get; set; }
        public void Init()
        {
            ProductSql = new EProductSql();

            ProductCM= new EProductsCM();
        }
    }
}
