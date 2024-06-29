using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Primo(9)); 
            Console.WriteLine(Primo(5)); 
        }

        static bool Primo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
