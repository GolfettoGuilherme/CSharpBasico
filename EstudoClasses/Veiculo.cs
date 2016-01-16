using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    //interfaces
    public abstract class Veiculo : IVeiculo
        //Superclasse
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Potencia { get; set; }

        //metodos abstratos não possuem descrição
        public abstract string Ligar();

        /*
        //metodos virtuais podem ser sobrescritos
        public virtual string Desligar()
        {
            return "O veiculo está desligado;";
        }
         * */

        public abstract string Desligar();


        public abstract string Abastecer();

        public string Desabastecer()
        {
            return "O veiculo ja foi desasbastecido";
        }
    }
}
