using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_de_Acesso.Protected
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 

    //Modificador de acesso protected tem a disponibilidade na classe ou na classe herdada
    //por não haver herança em struct esse modificador de acesso não se aplica pois o private já satisfaz o nível de acesso
    public class GenericOrientador
    {
        protected string _dataCadastro; //essa variável vai ficar disponível apenas para a classe e para classes que herdarão GenericOrientador
        private string _senha;// essa variável apenas a classe GenericOrientador tem acesso não há acesso para as classes que herdarão GenericOrientador
    }
    public class Orientador : GenericOrientador
    {
        public string RecuperarDataCadastro()
        {
            return _dataCadastro; // aqui conseguimos acessar a variável protected porém somente a classe Orientador enxerga a instância de Orientador não disponibiliza essa variável. 
        }
        public string RecuperarSenha()
        {
            // return _senha //ao descomentar essa linha vemos um erro de nível de acesso pois apenas GenericOrientador "enxerga" _senha
            return "";
        }
    }
}
