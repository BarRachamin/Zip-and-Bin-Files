using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinFile
{
    public class MainManager
    {
        private MainManager() { Init(); }

        private static readonly MainManager _Instance = new MainManager();

        public static MainManager Instance { get { return _Instance; } }

         public ReadBinFile readBin;


        public void Init()
        {
            readBin = new ReadBinFile();
        }
        }
}
