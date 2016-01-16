using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).ExecutarPrograma();
        }

        int LerInteiro()
        {
            Console.Write("Digite um número:");
            return int.Parse(Console.ReadLine());
        }

        int SomarNumeros(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }

        void ExecutarPrograma()
        {
            int numero1 = LerInteiro();
            int numero2 = LerInteiro();
            int soma = SomarNumeros(numero1, numero2);
            Console.WriteLine("Resposta = {0}", soma.ToString());
        }
    }
}
