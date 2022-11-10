using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Heranca.Multinivel
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 

    //Herança multinível temos uma herança de classes derivadas
    //Ocorre quando herdamos de uma classe que já herda de outra classe.
    public class Professor
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
    }
    public class ProfessorDoutor : Professor
    {
        public string NomeDoutorado { get; set; }
    }
    public class ProfessorOrientador : ProfessorDoutor
    {
        public string SalaOrientacao { get; set; }
    }
}
