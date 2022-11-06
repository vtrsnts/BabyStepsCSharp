using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_de_Acesso.Private
{
    //Modificador de acesso private tem a disponibilidade apenas dentro da classe/struct
    //não tem sentido termos uma classe/struct private pois não há como utilizarmos por termos colocado restrição total como faríamos para acessar??? não dá!.
    public class Diretor
    {

        private string _senha; //private -> a única forma de acesso se dá por dentro da classe ou seja apenas a classe tem a responsabilidade de manipular esse dado.
        public void GerarSenha()
        {
            _senha = "123456";
        }
        public string Nome { get; private set; } // Aqui temos a visibilidade public porém a manipulação da informação está privada ou seja temos apenas leitura do dado já a manipulação da informação apenas a classe pode realizar.

    }
}
