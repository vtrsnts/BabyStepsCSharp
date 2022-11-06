using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_de_Acesso.Internal
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 
    //Modificador de acesso internal tem a disponibilidade apenas no mesmo assembly (projeto) ou seja a visibilidade é apenas no projeto onde ele foi criado.
    internal class Professor
    {
        public string Nome { get; set; }
        internal int Idade { get; set; } // visibilidade apenas no mesmo assembly 

    }
    //quando não definimos um modificador de acesso na classe/struct é assumido o default que é o internal 
    class Aluno
    {
        //quando não definimos um modificador de acesso nas variáveis, métodos e propriedades é assumido o default de private. 
        string Nome { get; set; }
        int Idade { get; set; }

        string hello(string nome)
        {
            return @$"hello";
        }
    }
}
