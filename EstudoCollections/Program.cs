using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listaNumeros = new List<int>();
            //não precisa definir o tamanho da lista

            for(int i = 0; i <= 10; i++)
            {
                listaNumeros.Add(i);
            }

            listaNumeros.Remove(5);//remove o numero na lista
            listaNumeros.RemoveAt(2); //remove o indice correspondente na lista
            listaNumeros.Reverse(); //altera a ordem da lista
            int quant = listaNumeros.Count(); //tamanho da lista
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Tamanho da lista = {0} itens",quant);


            /*
            //DICTORARY
            //ela tem uma chave para controle
            Dictionary<string, string> meuDicionario = new Dictionary<string, string>();
            //<chave, valor>
            meuDicionario.Add("adicionar","significa somar");
            meuDicionario.Add("subtratir", "significa diminuir");
            
            foreach(string chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} significa {1}", chave, meuDicionario[chave]);
            }
            */

            Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "numero baixo");
            meuDicionario.Add(5, "numero medio");
            meuDicionario.Add(8, "numero alto");

            foreach(int chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} é um {1}", chave, meuDicionario[chave]);
            }
            Console.ReadKey();
        }
    }
}
