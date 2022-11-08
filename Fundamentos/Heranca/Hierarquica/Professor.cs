using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Hierarquica
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 

    //Herança Hierárquica temos uma classe base e N classes derivadas 
    public class Professor
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
    }
    public class ProfessorDoutor : Professor
    {
        public string NomeDoutorado { get; set; }
    }
    public class ProfessorOrientador :Professor
    {
        public string SalaOrientacao { get; set; }
    }
}
