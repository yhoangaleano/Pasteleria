using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    class Pastel : ICaja
    {
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private double _tamanio;

        public double tamanio
        {
            get { return _tamanio; }
            set { _tamanio = value; }
        }

        public List<Ingrediente> ListaIngredientes { get; set; }

        public Pastel()
        {
            ListaIngredientes = new List<Ingrediente>();
        }

        public bool agregarIngrediente(Ingrediente i)
        {
            try
            {
                ListaIngredientes.Add(i);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public Ingrediente buscarIngrediente(string nombreIngrediente)
        {
            try
            {
                foreach (Ingrediente item in ListaIngredientes)
                {
                    if (item.nombre == nombreIngrediente)
                    {
                        return item;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public decimal calcularCosto()
        {
            decimal total = 0;

            try
            {
                foreach (Ingrediente item in ListaIngredientes)
                {
                    total += item.precio;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return total;
        }

        public bool eliminarIngrediente(Ingrediente i)
        {
            try
            {
                Ingrediente ingredienteEliminar = this.buscarIngrediente(i.nombre);

                if (ingredienteEliminar == null)
                {
                    return false;
                }
                else
                {
                    ListaIngredientes.Remove(ingredienteEliminar);
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public void verIngredientes()
        {
            try
            {
                Console.WriteLine("Estos son los ingredientes necesarios para el pastel {0}:", this.nombre);

                foreach (Ingrediente item in ListaIngredientes)
                {
                    Console.WriteLine("Nombre del ingrediente: {0}, cantidad: {1}, precio: {2:C}",
                        item.nombre, item.cantidad, item.precio);
                }

                Console.WriteLine("--------------------------------------------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
