using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passagem por Valor
            /*int numero1 = 3;
            int numero2 = numero1;
            numero1 = 5;
            Console.WriteLine("numero = {0}, numero2 = {1}",numero1,numero2);
            Console.ReadKey();
            
            //Passagem por Referencia
            Teste teste1 = new Teste();
            teste1.quantidade = 3;
            Teste teste2 = teste1;
            teste1.quantidade = 5;

            Console.WriteLine("teste1.quantidade = {0}, teste2.quantidade = {1}", teste1.quantidade, teste2.quantidade);
            Console.ReadKey();*/

            Teste teste1 = new Teste();
            teste1.quantidade = 3;
            teste1.testePai = new Teste();
            teste1.testePai.quantidade = 6;
            Console.WriteLine("quantidade = {0}", teste1.quantidade);
            Console.WriteLine("quantidade testePai = {0}", teste1.testePai.quantidade);
            Console.ReadKey();


        }
    }

    class Teste
    {
        public int quantidade;

        public Teste testePai;
    }
}
