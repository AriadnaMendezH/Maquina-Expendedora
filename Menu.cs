using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora
{
    internal class Menu
    {
        private List<Producto> productos;

        public Menu()
        {
            productos = new List<Producto>();
            productos.Add(new Producto("Poki", 15.50, 10));
            productos.Add(new Producto("Pay", 12.00, 8));
            productos.Add(new Producto("Yomi", 18.75, 5));
            productos.Add(new Producto("Vuala", 22.30, 6));
        }

        public List<Producto> ObeteProductos()
        {
            return productos;
        }

        public Producto? ProductoSelect(string nombre)
        {
            foreach (Producto p in productos)
            {
                if (p.Nombre == nombre)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
