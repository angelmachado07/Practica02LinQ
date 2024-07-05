using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1 -- Ejercicio 1-a");
                Console.WriteLine("2 -- Ejercicio 1-b");
                Console.WriteLine("3 -- Ejercicio 2");
                Console.WriteLine("0 -- Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {

                    case "1":
                        //////Ejemplo
                        //Console.WriteLine("ejemplo");
                        //var consulta = from p in personas where p.Edad < 25 && p.Ciudad == "Lima" orderby p.Nombre descending select new { p.Nombre, p.Edad };
                        //foreach (var persona in consulta)
                        //{
                        //    Console.WriteLine($"{persona.Nombre} ({persona.Edad} anos)");
                        //}

                        List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 25, Ciudad = "Lima" },
                new Persona { Nombre = "Maria", Edad = 30, Ciudad = "Bogota" },
                new Persona { Nombre = "Pedro", Edad = 35, Ciudad = "Madrid" },
                new Persona { Nombre = "Ana", Edad = 20, Ciudad = "Lima" },
                new Persona { Nombre = "Jose", Edad = 40, Ciudad = "Buenos Aires" }
            };
                        Console.WriteLine("Personas que tengan una edad mayor a 30 y vivan en Bogotá.");
                        personas.Where(p => p.Edad >= 30 && p.Ciudad == "Bogota").ToList().ForEach(p => Console.WriteLine(p.Nombre));

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.ReadLine();
                Console.Clear();

            } while (opcion != "0");

            //////Ejemplo
            //Console.WriteLine("ejemplo");
            //var consulta = from p in personas where p.Edad < 25 && p.Ciudad == "Lima" orderby p.Nombre descending select new { p.Nombre, p.Edad };
            //foreach (var persona in consulta)
            //{
            //    Console.WriteLine($"{persona.Nombre} ({persona.Edad} anos)");
            //}

            //////Ejercicio 1 - a)
            //Console.WriteLine("Personas que tengan una edad mayor a 30 y vivan en Bogotá.");
            //personas.Where(p => p.Edad >= 30 && p.Ciudad == "Bogota").ToList().ForEach(p => Console.WriteLine(p.Nombre));

            //////Ejercicio 1 - b)
            //Console.WriteLine("Orden por edad (25 a 35)");
            //personas.OrderBy(p => p.Edad).Where(p => p.Edad >= 25 && p.Edad <= 35).ToList().ForEach(p => Console.WriteLine(p.Nombre));
            //---------------------------------

            //Ejercicio 2

            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

            //Console.WriteLine("Promedio por empresas \n*");
            //ce.promedioSalario();
            //Console.WriteLine("");

            //Console.WriteLine("Peces Gordos \n*");
            //ce.getCEO("CEO");

            //Console.WriteLine("");
            //Console.WriteLine("Planillas \n*");
            //ce.getEmpleadosOrdenados();
            //Console.WriteLine("");
            //Console.WriteLine("Planillas ordenadas por salario \n*");
            //ce.getEmpleadoOrdenadosSegun();

            //Console.WriteLine("\nIngrese la empresa: (entero 1 a 3)\n1 para IAlpha\n2 para Udelar\n3 para SpaceZ");
            //string _Id = Console.ReadLine();
            //try
            //{
            //    int _Empresa = int.Parse(_Id);
            //    ce.getEmpleadosEmpresa(_Empresa);
            //}
            //catch
            //{
            //    Console.WriteLine("Ha introducido un Id erroneo. Debe de ingresar  un numero entero");
            //}

            // Ejercicio 2.3 

            //Console.WriteLine("Ingrese el ID de la empresa para ver la cantidad de CEOs:");
            //if (int.TryParse(Console.ReadLine(), out int empresaId))
            //{
            //    var empresa = ce.listaEmpresas.FirstOrDefault(e => e.Id == empresaId);
            //    if (empresa != null)
            //    {
            //        string nombreEmpresa = empresa.Nombre;
            //        ce.getCantidadCEO(empresaId);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: No se encontró ninguna empresa con el ID ingresado.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Debe ingresar un número entero.");
            //}

            //Ejercicio 2.4

            //ce.getEmpleadoMasGana();

            //Ejercicio 2.5

            //ce.getEmpleadoGanaMas2200();

            //Ejercicio 2.6

            //ce.getEmpleadoMasGanaPorCargo();

            //Ejercicio 2.7

            //ce.getEmpleadoMasGanaPorEmpresa();











        }
    }
}
