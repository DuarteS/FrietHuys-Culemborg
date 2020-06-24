using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friethuys_Culemborg
{
    class Menu
    {
        string MName { get; }
        List<Product> Products;

        public Menu(string mname)
        {
            MName = mname;
            Products = new List<Product>();
        }

        public void NewProduct(string pname, double pprice)
        {
            Product newProduct = new Product(pname, pprice);
            Products.Add(newProduct);
        }
    }
}
