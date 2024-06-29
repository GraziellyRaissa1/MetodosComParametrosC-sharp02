using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CalculoDoAreaRetangulo(2.0, 1.0)); 
        }

        static double CalculoDoAreaRetangulo(double largura, double altura)
        {
            return largura * altura;
        }
    }
}
