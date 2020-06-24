using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friethuys_Culemborg
{
    class Product
    {
        static int IDSeeder = 0;

        int PID { get; }
        string PName { get; }
        double PPrice { get; }

        public Product(string pname, double pprice)
        {
            PID = IDSeeder;
            IDSeeder++;
            PName = pname;
            PPrice = pprice;
        }

        public String GetInfo()
        {
            return PName +  " - €"+ PPrice.ToString();
        }
    }
}
