using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friethuys_Culemborg
{
    class Receipt
    {
        static int IDSeeder = 0;

        int PID { get; }
        double RTotalPrice { get; }

        List<Product> BoughtProducts;

        public Receipt()
        {
            PID = IDSeeder;
            IDSeeder++;
            BoughtProducts = new List<Product>();
        }

        public void AddNewProduct(Product product)
        {
            BoughtProducts.Add(product);
        }
    }
}
