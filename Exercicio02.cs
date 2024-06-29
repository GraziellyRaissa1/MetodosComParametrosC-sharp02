using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio02
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(CalculoDoQuadrado(19)); 
        }

        static int CalculoDoQuadrado(int numero)
        {
            return numero * numero;
        }
    }
}
