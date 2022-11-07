using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Heranca
{
    //Para facilitar a visualização da herança vou colocar as classes em um único arquivo lembrando que não é a maneira correta de gerar classes!! 
    //
    public abstract class ProfessorGeneric
    {
        protected string Cartao { get; set; }
        protected DateTime DataValidadeCartao { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
    }
    public class Professor : ProfessorGeneric
    {
        public virtual int CalcularIdade()
        {
            return Idade;
        }
    }
    class ProfessorRM : Professor
    {
        public ProfessorRM()
        {
            Idade = 10;
            var idadeP = CalcularIdade();
        }

        public override int CalcularIdade()
        {
            return Idade -2;
        }
    }
    internal class ProfessorGennera : ProfessorGeneric
    {


    }

}
