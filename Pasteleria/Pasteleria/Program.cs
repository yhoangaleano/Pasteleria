using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    class Program
    {
        static void Main(string[] args)
        {

            string ingresar = "1";

            do
            {
                Console.WriteLine("Bienvenido a la panaderia de Harry");
                Pastel pastel = new Pastel();

                Console.WriteLine("Ingrese el nombre del pastel");
                pastel.nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el tamaño del pastel");
                pastel.tamanio = int.Parse(Console.ReadLine());



                string ingresarMenuPastel = "1";

                do
                {
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.WriteLine("Ahora puedes agregar, buscar, eliminar, listar o calcular el costo de tu pastel");
                    Console.WriteLine("Ingresa 1 Para agregar un ingrediente");
                    Console.WriteLine("Ingresa 2 Para buscar un ingrediente");
                    Console.WriteLine("Ingresa 3 Para eliminar un ingrediente");
                    Console.WriteLine("Ingresa 4 Para ver la lista de ingredientes");
                    Console.WriteLine("Ingresa 5 Para calcular el costo del pastel");
                    Console.WriteLine("-------------------------------------------------------------------------------");

                    string opcionSubmenu = Console.ReadLine();

                    switch (opcionSubmenu)
                    {
                        case "1":

                            Ingrediente ingrediente = new Ingrediente();

                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine("Ingrese el nombre del ingrediente");
                            ingrediente.nombre = Console.ReadLine();

                            Console.WriteLine("Ingrese la cantidad necesaria del ingrediente");
                            ingrediente.cantidad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el valor total del ingrediente");
                            ingrediente.precio = decimal.Parse(Console.ReadLine());

                            if(pastel.agregarIngrediente(ingrediente) == true)
                            {
                                Console.WriteLine("Ingrediente agregado");
                            }
                            else
                            {
                                Console.WriteLine("El ingrediente no se pudo agregar");
                            }
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            
                            break;

                        case "2":


                            Console.WriteLine("Ingrese el nombre del ingrediente a buscar:");
                            string nombreIngrediente = Console.ReadLine();

                            Ingrediente ingredienteBuscado = pastel.buscarIngrediente(nombreIngrediente);

                            if (ingredienteBuscado == null)
                            {
                                Console.WriteLine("El ingrediente no se encuentra en la lista para el pastel");
                            }
                            else
                            {
                                Console.WriteLine("La información del ingrediente es:");
                                Console.WriteLine("Nombre: {0}", ingredienteBuscado.nombre);
                                Console.WriteLine("Cantidad: {0}", ingredienteBuscado.cantidad);
                                Console.WriteLine("Precio: {0}", ingredienteBuscado.precio);
                            }

                            break;

                        case "3":


                            Console.WriteLine("Ingrese el nombre del ingrediente a buscar:");
                            string nombreIngredienteEliminar = Console.ReadLine();

                            Ingrediente ingredienteEliminar = pastel.buscarIngrediente(nombreIngredienteEliminar);

                            if (ingredienteEliminar == null)
                            {
                                Console.WriteLine("El ingrediente no se encuentra en la lista para el pastel");
                            }
                            else
                            {
                                if (pastel.eliminarIngrediente(ingredienteEliminar) == true)
                                {
                                    Console.WriteLine("El ingrediente fue eliminado correctamente");
                                }
                                else
                                {
                                    Console.WriteLine("El ingrediente no pudo ser eliminado");
                                }
                            }

                            break;

                        case "4":

                            pastel.verIngredientes();

                            break;

                        case "5":

                            Console.WriteLine("El costo del pastel {0} es: {1:C}", pastel.nombre, pastel.calcularCosto());

                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("¿Deseas ingresar al submenu del pastel? 1 Para si - 2 Para no");
                    ingresarMenuPastel = Console.ReadLine();

                } while (ingresarMenuPastel == "1");


                Console.WriteLine("¿Desea crear otro pastel?, 1 Para si - 2 Para no");
                ingresar = Console.ReadLine();

            } while (ingresar == "1");

        }
    }
}
