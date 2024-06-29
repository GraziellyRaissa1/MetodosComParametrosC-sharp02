using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosCsharp02
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Palindromo("Olá")); 
            Console.WriteLine(Palindromo("Programadores")); 
        }

        static bool Palindromo(string texto)
        {
            int esquerda = 0;
            int direita = texto.Length - 1;
            while (esquerda < direita)
            {
                if (texto[esquerda] != texto[direita])
                {
                    return false;
                }
                esquerda++;
                direita--;
            }
            return true;
        }
    }
}
