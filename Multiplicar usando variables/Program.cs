using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicar_usando_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int multiplicacion;

            Console.WriteLine("Enter 1st number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            number2 = Convert.ToInt32(Console.ReadLine());

            multiplicacion = number1 * number2;

            Console.WriteLine("The multiplication is: ");
            Console.WriteLine(multiplicacion);
            Console.ReadLine();


        }
    }
}
