using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    class Ingrediente
    {
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private decimal _precio;

        public decimal precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

    }
}
