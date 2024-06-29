using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio07
    {
        public static void Main(string [] args )
        {
            Console.WriteLine(CalculoDoFatorial(300)); 
        }

        static int CalculoDoFatorial(int numero)
        {
            if (numero == 0) return 1;
            int fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
