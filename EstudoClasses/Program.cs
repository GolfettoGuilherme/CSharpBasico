using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto do tipo Carro
            Carro carro = new Carro();

            carro.Marca = "Fiat"; //vai chamar o set automático

            Console.WriteLine("A marca do carro é {0}", carro.Marca); //vai charmar o get auto

            carro.AdicionarAntigoDono("João da Silva");
            carro.AdicionarAntigoDono("Maria");

            foreach(string nome in carro.GetAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é {0}", nome);
            }

            Console.WriteLine(carro.Ligar());

            Console.WriteLine(Carro.GetSoma(3, 4));

            Console.ReadKey();


        }
    }
}
