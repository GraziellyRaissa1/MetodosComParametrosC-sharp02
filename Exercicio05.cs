using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio05
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(AnoBissexto(2045)); 
            Console.WriteLine(AnoBissexto(2075)); 
        }

        static bool AnoBissexto(int ano)
        {
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }
    }
}
