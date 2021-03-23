using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;


namespace S7NetPlus
{
    public  class StaticClass
    {
        public static string IP_Address = null;
        public static Plc plc = new Plc(CpuType.S71200,IP_Address,0,1);
    }
}
