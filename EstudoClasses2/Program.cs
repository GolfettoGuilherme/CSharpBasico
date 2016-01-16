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
            Carro carro = new Carro();
            carro.Marca = "fiat";
            //struct
            Dono donoJoao = new Dono();
            donoJoao.Nome = "João";
            donoJoao.Idade = 30;

            Dono donoMaria = new Dono();
            donoMaria.Nome = "Maria";
            donoMaria.Idade = 28;

            carro.AdicionarAntigoDono(donoJoao);
            carro.AdicionarAntigoDono(donoMaria);

            foreach (Dono dono in carro.GetAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é {0} com idade de {1} ",dono.Nome,dono.Idade);

            }

            Console.WriteLine(carro.Ligar());
            Console.WriteLine("este carro tem {0} portas", carro.NumeroPortas);

            Carro carro2 = new Carro("Astra");

            Console.WriteLine("Este outro carro se chama {0}", carro2.Nome);

            Carro carro3 = new Carro("Ford",numero: 2);

            Console.WriteLine("este carro é da marca {0} e tem {1} portas", carro3.Nome, carro3.NumeroPortas);

            Carro carro4 = new Carro(nome: "ka",marca: "Ford"); //não precisa da ordem, só atribuir o nome dos bois
            Console.WriteLine("este ultimo carro é da mara {0}, tem {1} portas e seu nome é {2}", carro4.Marca, carro4.NumeroPortas, carro4.Nome);

            //construtor anonimo - ele chama o padrão e define os sets
            Carro carro6 = new Carro
            {
                Nome = "Astra",
                Marca = "GM",
                NumeroPortas = 4,
                Potencia = 1.4
            };

            Console.WriteLine("Agora esse carro se chama {0}, é da marca {1} e tem {2} portas com {3} de potência", carro6.Nome, carro6.Marca, carro6.NumeroPortas, carro6.Potencia);


            Carro carro7 = new Carro();
            Console.WriteLine("Mensagem do carro: {0}",carro7.Ligar());


            Moto moto1 = new Moto();
            moto1.Nome = "Titan";
            moto1.Marca = "Honda";
            moto1.CapacidadeTanque = 15;
            moto1.Potencia = 150;

            Console.WriteLine("Essa moto {0} é da marca {1} com {2} cilindradas e com {3} litros de tanque", moto1.Nome, moto1.Marca, moto1.Potencia, moto1.CapacidadeTanque);


            Carro carrFord = new Carro();

            carrFord.Nome = "Ka";
            carrFord.Marca = "Ford";

            Carro carroFord = new Carro();
            carroFord.Nome = "Ka";
            carroFord.Marca = "Ford";

            Console.WriteLine(carrFord.Ligar());
            Console.WriteLine("GetHashCode = {0}", carrFord.GetHashCode());
            Console.WriteLine("ToString = {0}", carrFord.ToString());
            Console.WriteLine("Equals = {0}",carrFord.Equals(carroFord));

            //poliformismo
            Veiculo meuCarro = new Carro();
            Veiculo minhaMoto = new Moto();

            Console.WriteLine("Ligando o carro: {0}", meuCarro.Ligar());
            Console.WriteLine("Ligando a Moto: {0}", minhaMoto.Ligar());
            Console.WriteLine("Desligando o carro: {0}", meuCarro.Desligar());
            Console.WriteLine("Desligando a Moto: {0}", minhaMoto.Desligar());


            Console.WriteLine("Abastecendo o carro {0}",meuCarro.Abastecer());
            Console.WriteLine("Abastecendo a moto {0}", minhaMoto.Abastecer());

            /* não faz sentido, se ele não é carro nem moto, não é nada
            Veiculo meuVeiculo = new Veiculo();
            Console.WriteLine("Mensagem do Veiculo = {0}", meuVeiculo.Ligar());
            */

            //polimorfismo em nivel de interface
            IVeiculo meuCaminhao = new Caminhao();
            Console.WriteLine("Mensagem do caminhao: {0}", meuCaminhao.Ligar());
            Console.WriteLine("Abastecendo o Caminhão {0}", meuCaminhao.Abastecer());
            Console.WriteLine("Abastecendo o Caminhão {0}", meuCaminhao.Desabastecer());
            Console.WriteLine("Mensagem do caminhao: {0}", meuCaminhao.Desligar());
            Console.ReadKey();
        }
    }
}
