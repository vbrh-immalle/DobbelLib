using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobbelLib
{
    public class Dobbelsteen
    {
        private static Random rndGen = new Random();

        private int waarde = 0;

        public void Werp()
        {
            waarde = rndGen.Next(6) + 1;
        }

        public int Waarde
        {
            get
            {
                return waarde;
            }
        }
    }
}
