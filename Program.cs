using System;
using System.Globalization;

namespace Salarial
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("===========================================");
            Console.WriteLine(" CALCULADORA DE ISR - REPUBLICA DOMINICANA ");
            Console.WriteLine("===========================================");

            Console.Write("\nPor favor, introduzca el sueldo mensual (RD$): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal sueldoMnesual) && sueldoMnesual >= 0)
            {
                decimal sueldoAnual = sueldoMnesual * 12;
                decimal isrAnual = 0;
                bool aplicaISR = true;

            if (sueldoAnual <= 416220.00m)
                {
                    aplicaISR = false;
                }
                else if (sueldoAnual <= 624329.00m)
                {
                    decimal excedente = sueldoAnual - 416220.01m;
                    isrAnual = excedente * 0.15m;
                }
                else if (sueldoAnual <= 867123.00m)
                {
                    decimal excedente = sueldoAnual - 624329.01m;
                    isrAnual = 31216.00m + (excedente * 0.20m);
                }
                else
                {
                    decimal excedente = sueldoAnual - 867123.01m;
                    isrAnual = 79776.00m + (excedente * 0.25m); 
                }

                decimal isrMensual = isrAnual / 12;

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Sueldo Mensual Evaluado: RD$ {sueldoMnesual:N}");

                if (aplicaISR)
                {
                    Console.WriteLine($"Monto a pagar de ISR (Mensual): RD$ {isrMensual:N}");
                }
                else
                {
                    Console.WriteLine("Monto a pagar de ISR (Mensual): N/A");
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                
            }
            else
            {
                Console.WriteLine("\n[ERROR] El sueldo ingresado no es valido.");
            }

            Console.WriteLine("\n>>>Presione cualquier tecla para salir<<<");
            Console.ReadKey();
        }
    }
}
