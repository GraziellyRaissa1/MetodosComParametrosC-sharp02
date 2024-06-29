using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(VerificandoNumero(-80)); // "Negativo"
            Console.WriteLine(VerificandoNumero(0)); // "Zero"
            Console.WriteLine(VerificandoNumero(1050)); // "Positivo"
        }

        static string VerificandoNumero(int numero)
        {
            if (numero > 0)
                return "Positivo";
            else if (numero < 0)
                return "Negativo";
            else
                return "Zero";
        }
    }
}
