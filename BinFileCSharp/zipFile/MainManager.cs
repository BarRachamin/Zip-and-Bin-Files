using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zipFile
{
    public class MainManager
    {
        private MainManager() { Init(); }

        private static readonly MainManager _Instance = new MainManager();

        public static MainManager Instance { get { return _Instance; } }

      public CreateZipFile zipFile { get;  set; }


        public void Init()
        {
           zipFile = new CreateZipFile();
        }
    }
}
