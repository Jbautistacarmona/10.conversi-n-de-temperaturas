using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.conversión_de_temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige la escala de temperatura inicial: \n 1. Celsius \n 2. Fahrenheit \n 3. Kelvin");
            int opcion = int.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el número de punto flotante de precisión doble equivalente
            Console.WriteLine("Ingresa la temperatura: ");
            double temp = double.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente

            if (opcion == 1) //La instrucción if controla la bifurcación condicional
            {
                Console.WriteLine("La temperatura en Fahrenheit es: " + (temp * 9 / 5 + 32)); //dependiendo de la la escala inicial, se irmprime en los datos valores difentes
                Console.WriteLine("La temperatura en Kelvin es: " + (temp + 273.15));
            }
            else if (opcion == 2) //Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida.
            {
                Console.WriteLine("La temperatura en Celsius es: " + ((temp - 32) * 5 / 9)); ////dependiendo de la la escala inicial, se irmprime en los datos valores difentes
                Console.WriteLine("La temperatura en Kelvin es: " + ((temp - 32) * 5 / 9 + 273.15));
            }
            else if (opcion == 3)
            {
                Console.WriteLine("La temperatura en Celsius es: " + (temp - 273.15));
                Console.WriteLine("La temperatura en Fahrenheit es: " + ((temp - 273.15) * 9 / 5 + 32));
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }
             Console.ReadLine(); //imprime resultado. 
        }
    }
}
