using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Par(7)); 
            Console.WriteLine(Par(10)); 
        }

        static bool Par(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
