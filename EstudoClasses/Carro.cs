using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public class Carro
    {

        private string marca;


        //prop + tab + tab para criar as propriedades
        public string Nome { get; set; }

        public string Marca {
            //assim posso colocar logicas neles
            get { return marca; }
            set
            {
                if(value == "Fiat")
                {
                    marca = "Ford";
                }
                else
                {
                    marca = value;
                }
            }
        }

        public int NumeroPortas { get; set; }

        public double Potencia { get; set; }

        private List<string> antigosDonos = new List<string>();

        public void AdicionarAntigoDono(string nomeAntigoDono)
        {
            antigosDonos.Add(nomeAntigoDono);
        }

        public List<string> GetAntigosDonos()
        {
            return antigosDonos;
        }

        public string Ligar()
        {
            return "O Carro agora está ligado";
        }

        public static int GetSoma(int a,int b)
        {
            return a + b;
        }
    }
}
