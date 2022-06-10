using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Examen_Unidad_6
{
    class Program
    {
        class Amazon
        {
            // Campos de la clase
            public string nom_Producto;
            public string descripción;
            public float precio;
            public int cantidad_stock; 

            // Cosntructor de la clase
            public Amazon(string nom_Producto,string descripción, float precio,int cantidad_stock )
            {
                this.nom_Producto = nom_Producto;
                this.descripción = descripción;
                this.precio = precio;
                this.cantidad_stock = cantidad_stock; 


            }

            // Destructor de la clase
            ~Amazon()
            {
                Console.WriteLine(" Memoria Liberada de la clase Amazon "); 
            }
        }

        static void Main(string[] args)
        {
            // Declaración de variables
            string nom_p;
            string descrip;
            float precio;
            int cant_stocks;
            int opción;

            Console.WriteLine(" Bienvenido al Sistema de Amazon ");
            do
            {
               
                Console.WriteLine("\nMenu de opciones" +
                    "\n1)Ingresar datos del producto:  " +
                    "\n2) Leer Nota" + "\n" +
                      "3) Salida del programa");

                Console.Write("Ingresa la opción que deseas: "); 
                opción = int.Parse(Console.ReadLine()); 
                switch (opción)
                {
                    case 1:
                        StreamWriter producto = new StreamWriter("Producto.txt", true);


                        Console.Write("Ingresa el nombre del producto: ");
                        nom_p = Console.ReadLine();

                        Console.Write("Ingresa La descripción del producto: ");
                        descrip = Console.ReadLine();

                        Console.Write("Ingresa el precio del producto: ");
                        precio = float.Parse(Console.ReadLine());

                        Console.Write("favor de ingresar la cantidad de estoks: ");
                        cant_stocks = int.Parse(Console.ReadLine());

                        producto.WriteLine("\n" + nom_p + " " + "\n" + descrip + " " + "\n" + precio + " " + "\n" + cant_stocks);
                        producto.Close(); 

                        break;
                    case 2:
                        StreamReader Leer = new StreamReader("producto.txt", true);
                        Leer.ReadLine(); 
                        break; 
                    case 3:
                        Console.Write("Presiona enter para salir del programa: "); 
                        break;

                    default:
                        Console.Write("Esta Opción nose encuentra en el menu "); 
                        break; 

                }

            } while (opción != 2);

            Console.ReadLine(); 
        }
    }
}
