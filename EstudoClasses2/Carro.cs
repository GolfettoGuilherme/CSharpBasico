using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public sealed class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        private List<Dono> antigosDonos;

        public void AdicionarAntigoDono(Dono dono) 
        {
            antigosDonos.Add(dono);
        }

        public List<Dono> GetAntigosDonos() 
        {
            return antigosDonos;
        }

        public Carro()
        {
            this.antigosDonos = new List<Dono>();
            this.NumeroPortas = 4;
        }

        public Carro(string nome)
        {
            this.Nome = nome;
        }
        public Carro(string nome, int numero)
        {
            this.Nome = nome;
            this.NumeroPortas = numero;
        }

        public Carro(string marca, string nome, int portas = 4)
        {
            this.Marca = marca;
            this.Nome = nome;
            this.NumeroPortas = portas;
        }

        //sobescrever um metodo
        public override bool Equals(object obj)
        {
            Carro carro2 = (Carro)obj;
            return carro2.Nome == this.Nome && carro2.Marca == this.Marca;
        }

        public override string ToString()
        {
            return string.Format("Carro: Nome = {0}, Marca = {1}",this.Nome,this.Marca);
        }

        public override string Ligar()
        {
            return "o carro está ligado";
        }

        public override string Desligar()
        {
            return "o carro está desligado";
        }

        public override string Abastecer()
        {
            return "O Carro está abastecido";
        }
    }
}
