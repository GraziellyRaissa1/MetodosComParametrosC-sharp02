using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CalculoDoMedia(55.0, 61.0, 72.0)); 
        }

        static double CalculoDoMedia(double numero1, double numero2, double numero3)
        {
            return (numero1 + numero2 + numero3) / 3;
        }
    }
}
