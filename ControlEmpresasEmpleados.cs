using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica02LinQ
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas; 
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "IAlpha" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Udelar" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "SpaceZ" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 1, Salario = 4000});
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2500 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "GonzaloT", Cargo = "CEO", EmpresaId = 2, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });
        }

        public void getCEO(string Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.Cargo == Cargo
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Nombre
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        public void getEmpleadoOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Salario
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas on empleado.EmpresaId
                                              equals empresa.Id
                                              where empresa.Id == _Empresa
                                              select empleado;
            foreach (var item in empleados)
            {
                item.getDatosEmpleado();
            }
        }

        //_________ Metodos Particulares __________

        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaId into g
                           select new { empresa = g.Key, PromedioSalario = g.Average(e => e.Salario) };
            foreach (var item in consulta)
            {
                switch (item.empresa)
                {
                    case 1:
                        Console.WriteLine($"Empresa IAlpha - Promedio de salario : {item.PromedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Empresa Udelar - Promedio de salario : {item.PromedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Empresa SpaceZ - Promedio de salario : {item.PromedioSalario}");
                        break;

                }
            }
        }

        //EjerciciosFoto
        public void getCantidadCEO(int empresaId)
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados
                                         where empleado.Cargo == "CEO" && empleado.EmpresaId == empresaId
                                         select empleado;

            int cantidadCEOs = ceos.Count();

            Console.WriteLine($"Cantidad de CEOs en la empresa con Id {empresaId}: {cantidadCEOs}");
        }


        public void getEmpleadoMasGana()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Salario descending
                                              select empleado;

            foreach (Empleado empleadoMasGana in empleados)
            {
                Console.WriteLine("\nEmpleado que gana más:");
                empleadoMasGana.getDatosEmpleado();

                break;
            }
        }

        public void getEmpleadoGanaMas2200()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.Salario > 2200
                                              orderby empleado.Salario descending
                                              select empleado;

            Console.WriteLine("\nEmpleados que ganan más de 2200:\n");
            foreach (Empleado empleadoMasGana in empleados)
            {
                empleadoMasGana.getDatosEmpleado();
            }
        }

        public void getEmpleadoMasGanaPorCargo()
        {
            string[] cargos = { "CEO", "Desarrollador" };

            foreach (string cargo in cargos)
            {
                IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                                  where empleado.Cargo == cargo
                                                  orderby empleado.Salario descending
                                                  select empleado;

                Console.WriteLine($"\n{cargo} que gana más:");
                empleados.First().getDatosEmpleado();
            }
        }

        public void getEmpleadoMasGanaPorEmpresa()
        {
            var empleadosPorEmpresa = from empleado in listaEmpleados
                                      group empleado by empleado.EmpresaId into grupo
                                      select grupo.OrderByDescending(e => e.Salario).FirstOrDefault();

            Console.WriteLine("\nEmpleado que gana más por empresa:");
            foreach (Empleado empleado in empleadosPorEmpresa)
            {
                empleado.getDatosEmpleado();
            }
        }




    }
}
