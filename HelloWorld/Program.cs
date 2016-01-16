using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World Again");
            Console.ReadKey(); //usado para pausar o console até o usuario pressionar alguma tecla
            */
            //Inferencia - não precisa estipular o tipo
            int inteiro1 = 4;
            var inteiro2 = 4;
            var nome = "Guilherme";
            Console.WriteLine("inteiro2 = {0}", inteiro2);
            Console.WriteLine(nome);

            //dynamic = variavel pode mudar de tipo (pesa mais na memoria)
            dynamic minhaVariavel = 2;
            Console.WriteLine("inteir1 + minhaVarial = {0}", inteiro1 + minhaVariavel);
            minhaVariavel = "TreinaWeb"; //agora ela passa a ser String.
            Console.Write("minhaVariavel = {0}", minhaVariavel);
            Console.ReadKey();

        }
    }
}
