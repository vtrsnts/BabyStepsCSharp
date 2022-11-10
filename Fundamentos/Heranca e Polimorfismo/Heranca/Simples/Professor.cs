using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Heranca.Simples
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 

    //Herança simples temos uma classe origem (base) e uma classe derivada (filha)
    public class Professor
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
    }
    public class ProfessorDoutor : Professor
    {
        public string NomeDoutorado { get; set; }
    }
}
