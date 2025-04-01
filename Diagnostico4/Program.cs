using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostico4
{
    public class Datos 
    {
        public string Nombre, Apellido;
        public int Nro, Altura, Tiempo, Categoria;

        public void CargarDatos() 
        {
            Console.WriteLine("Ingrese el Numero del participante");
            Nro = int.Parse(Console.ReadLine());
            if (Nro != 0) 
            {
                Console.WriteLine("Ingrese la Categoria del participante");
                Categoria = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre del participante");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Apellido del participante");
                Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la Altura del participante en centimetros");
                Altura = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Tiempo en segundos");
                Tiempo = int.Parse(Console.ReadLine());
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> Categorias = new List<int>();
            List<int> TiempoCat = new List<int>();
            List<int> NroCat = new List<int>();

            int MejorTiempo = 99999;
            Datos Datos = new Datos();
            do
            {
                Datos.CargarDatos();
                if (Datos.Nro != 0)
                {
                    for (int i = 1; i < Categorias.Count; i++)
                    {
                        if (Datos.Categoria == Categorias[i])
                        {
                            if (Datos.Tiempo < TiempoCat[i])
                            {
                                TiempoCat[i] = Datos.Tiempo;
                                NroCat[i] = Datos.Nro;
                                break;
                            }
                        }
                        else
                        {
                            Categorias.Add(Datos.Categoria);
                            TiempoCat.Add(Datos.Tiempo);
                            NroCat.Add(Datos.Nro);
                            break;
                        }
                    }
                }
                if (Datos.Tiempo < MejorTiempo) 
                {
                    MejorTiempo = Datos.Tiempo;
                }
                Console.Clear();
            } while (Datos.Nro != 0);
            Console.WriteLine("El mejor tiempo fue: " + MejorTiempo); Console.ReadKey();
            foreach (int i in Categorias)
            {
                Console.WriteLine("El mejor tiempo en la Categoria " + Categorias[i] + "Fue: " + TiempoCat[i] + "Por el Numero: " + NroCat[i]);
            }
            Console.ReadKey();
        }
    }
}
