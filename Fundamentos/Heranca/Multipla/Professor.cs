using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Multipla
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 

    //Herança múltipla -> não há herança múltipla de classe no C# temos a possibilidade de criar estrutura que permita um comportamento de herança múltipla utilizando Interface. 
    public interface IProfessor
    {
         int Idade { get; set; }
         string Nome { get; set; }
    }
    public interface IDiretor 
    {
         void AvaliarProfessor();
    }
    public class ProfessorDoutor
    {
        public string NomeDoutorado { get; set; }
        public string CPF { get; set; }       
    }
    public class ProfessorOrientador : ProfessorDoutor, IProfessor, IDiretor
    {
        public string SalaOrientacao { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }

        public void AvaliarProfessor()
        {
            throw new NotImplementedException();
        }
    }
}
