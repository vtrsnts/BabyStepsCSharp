using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Polimorfismo.Heranca
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 
    //Polimorfismo -> Várias formas!
    //Polimorfismo na Herança ocorre quando uma classe sobreescreve uma ação herdada gerando uma nova forma para o mesmo método herdado.
    internal class Pessoa
    {
        public virtual int Locomover() 
        {
            int km = 10;
            return km;
        }       
    }   
    internal class Aluno : Pessoa
    {
        public override int Locomover()
        {
            int km = base.Locomover()+ 10;
            return km;
        }       
    }
    internal class Professor : Pessoa
    {
        public override int Locomover()
        {
            int km = 30;
            return km;
        }
    }
    internal class Diretor : Professor
    {
        public override int Locomover()
        {
            int km = 40;
            return km;
        }
    }
}
