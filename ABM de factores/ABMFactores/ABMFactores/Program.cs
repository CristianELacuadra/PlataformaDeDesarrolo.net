using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMFactores
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 n;
            Factor f = new Factor();
            Valor v = new Valor();

            Console.WriteLine("Escriba el número de la opción que desea y presione enter.");
            Console.WriteLine(" ");
            Console.WriteLine("1- Listar factores");
            Console.WriteLine("2- Agregar factor");
            Console.WriteLine("3- Modificar factor");
            Console.WriteLine("4- Eliminar factor");
            Console.WriteLine(" ");
            Console.WriteLine("0- Salir");

            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:

                    f.MostrarFactor();
                    Console.WriteLine("Ingrese ID del factor deseado para ver valores");
                    v.IDFactor = int.Parse(Console.ReadLine());
                    v.MostrarValor();
                    break;

                case 2:

                    Console.WriteLine("Introduzca id y nombre del factor");
                    f.IDFactor = int.Parse(Console.ReadLine());
                    f.NombreFactor = Console.ReadLine();
                    f.AltaFactor();
                    for(int i = 1; i<=3; i++)
                    {
                        Console.WriteLine("Ingrese datos del valor " + i);
                        v.IDValor = int.Parse(Console.ReadLine());
                        v.Denominacion = Console.ReadLine();
                        v.NumValor = int.Parse(Console.ReadLine());
                        v.IDFactor = f.IDFactor;
                        v.AltaValor();
                    }
                    break;

                case 3:

                    Console.WriteLine("Ingrese ID del factor que desea modificar");
                    v.IDFactor = int.Parse(Console.ReadLine());
                    v.MostrarValor();
                    Console.WriteLine("Ingrese ID del valor que desea modificar");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese nuevos datos del valor");
                    v.IDValor = int.Parse(Console.ReadLine());
                    v.Denominacion = Console.ReadLine();
                    v.NumValor = int.Parse(Console.ReadLine());
                    v.IDFactor = int.Parse(Console.ReadLine());
                    v.ModificarValor(n);
                    break;

                case 4:

                    Console.WriteLine("Ingrese ID del factor que desea eliminar");
                    f.IDFactor = int.Parse(Console.ReadLine());
                    f.BajaFactor();
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
