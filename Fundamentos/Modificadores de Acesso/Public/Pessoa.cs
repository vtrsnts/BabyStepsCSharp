using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_de_Acesso.Public
{

    //Modificador de acesso public tem a disponibilidade completa em outra parte do projeto ou em projetos externos que fazem referência.
    public class Pessoa
    {
        public string Nome { get; set; } //public ->  disponibiliza a visibilidade na instância do objeto em qualquer projeto que tenha referência
        internal int Idade { get; set; } //internal -> visibilidade apenas para o mesmo projeto/assembly
    }
}
