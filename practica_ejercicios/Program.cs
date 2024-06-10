using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("favor digite su numero de cedula");
            string Cedula = Console.ReadLine();

            Console.WriteLine("favor digite su nombre");
            string NombreEmpleado = Console.ReadLine();


            Console.WriteLine("favor digite su salario por hora");
            int SalarioporHora = int.Parse(Console.ReadLine());

            Console.WriteLine("favor digite la cantidad de horas");
            int CantidaddeHoras = int.Parse(Console.ReadLine());

            float SalarioOrdinario = CantidaddeHoras * SalarioporHora;
            double Aumento = 0;

            Double SalarioBruto = SalarioOrdinario + Aumento;

            Double Deduccion = 0.0917;

            Double SalarioNeto = SalarioBruto - Deduccion;
            int cantidadempleadostipo1 = 0;
            int cantidadempleadostipo2 = 0;
            int cantidadempleadostipo3 = 0;
            Double acumuladosalarionetotipo1 = 0;
            Double acumuladosalarionetotipo2 = 0;
            Double acumuladosalarionetotipo3 = 0;
            double promediosalarionetotipo1 = 0;
            double promediosalarionetotipo2 = 0;
            double promediosalarionetotipo3 = 0;


            for (int i = 0; i < 0; i++)

            {
                Console.WriteLine("Favor seleccione el tipo de operario para calcular el aumento");
                Console.WriteLine("1.OPERARIO");
                Console.WriteLine("2.TECNICO");
                Console.WriteLine("3.PROFESIONAL");
                string op = Console.ReadLine();
                op = op.ToUpper();
               

                if (op == "1")
                {
                    Aumento = 0.15;
                    cantidadempleadostipo1++;
                    acumuladosalarionetotipo1 = acumuladosalarionetotipo1 + SalarioNeto;
                    promediosalarionetotipo1 = acumuladosalarionetotipo1 / cantidadempleadostipo1;
                    Console.WriteLine($"Cedula:{Cedula}\r\nNombre Empleado:{NombreEmpleado}\r\nTipo Empleado:{op}\r\nSalario por Hora{SalarioporHora}\r\nCantidad de Horas{CantidaddeHoras}\r\n");
                    Console.WriteLine($"su salario ordinario es de {SalarioOrdinario} + el aumento de {Aumento} da un salario bruto de {SalarioBruto} - las deducciones de la ccss da como resultado un salario neto de {SalarioNeto}");
                }
                if (op == "2")
                {
                    Aumento = 0.10;
                    cantidadempleadostipo2++;
                    promediosalarionetotipo2 = acumuladosalarionetotipo2 / cantidadempleadostipo1;
                    acumuladosalarionetotipo2 = acumuladosalarionetotipo2 + SalarioNeto;
                    Console.WriteLine($"Cedula:{Cedula}\r\nNombre Empleado:{NombreEmpleado}\r\nTipo Empleado:{op}\r\nSalario por Hora{SalarioporHora}\r\nCantidad de Horas{CantidaddeHoras}\r\n");
                    Console.WriteLine($"su salario ordinario es de {SalarioOrdinario} + el aumento de {Aumento} da un salario bruto de {SalarioBruto} - las deducciones de la ccss da como resultado un salario neto de {SalarioNeto}");
                }
                if (op == "3")
                {
                    Aumento = 0.05;
                    cantidadempleadostipo3++;
                    promediosalarionetotipo3 = acumuladosalarionetotipo3 / cantidadempleadostipo1;
                    acumuladosalarionetotipo3 = acumuladosalarionetotipo3 + SalarioNeto;
                    Console.WriteLine($"Cedula:{Cedula}\r\nNombre Empleado:{NombreEmpleado}\r\nTipo Empleado:{op}\r\nSalario por Hora{SalarioporHora}\r\nCantidad de Horas{CantidaddeHoras}\r\n");
                    Console.WriteLine($"su salario ordinario es de {SalarioOrdinario} + el aumento de {Aumento} da un salario bruto de {SalarioBruto} - las deducciones de la ccss da como resultado un salario neto de {SalarioNeto}");
                }
                Console.WriteLine("desea registrar mas datos ?");
                Console.WriteLine("digite 1 para continuar y 2 para salir");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")

                {
                    i = 1;

                }

                else

                {
                    Console.WriteLine($"Cantidad Empleados Tipo Operarios" + cantidadempleadostipo1 +
                        $"\r\nAcumulado Salario Neto para Operarios" + acumuladosalarionetotipo1 +
                        $"\r\nPromedio Salario Neto para Operarios" + promediosalarionetotipo1 +
                        $"\r\nCantidad Empleados Tipo Técnico" + cantidadempleadostipo2 +
                        $"\r\nAcumulado Salario Neto para Técnicos" + acumuladosalarionetotipo2 +
                        $"\r\nPromedio Salario Neto para Técnicos" +promediosalarionetotipo2 +
                        $"\r\nCantidad Empleados Tipo Profesional" + cantidadempleadostipo3+
                        $"\r\nAcumulado Salario Neto para Profesional" +acumuladosalarionetotipo3 +
                        $"\r\nPromedio Salario Neto para Profesionales" +promediosalarionetotipo3+
                        $"\r\n");
                }

                

            }
            Console.ReadKey();
        }
    }
}