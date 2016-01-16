using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public sealed class Caminhao : Veiculo
    {

        public override string Ligar()
        {
            return "o caminhão está ligado";
        }

        public override string Desligar()
        {
            return "o caminhão está desligado";
        }

        public override string Abastecer()
        {
            return "O caminhão está abastecido";
        }
    }
}
