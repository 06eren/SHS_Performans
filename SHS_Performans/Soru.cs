using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHS_Performans
{
    public class Soru
    {
        public string SoruMetni { get; set; }
        public string[] Secenekler { get; set; } = new string[5]; 
        public string DogruCevap { get; set; }
    }
}
