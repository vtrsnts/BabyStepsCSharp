using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipos_e_Variaveis.Interface;

namespace Tipos_e_Variaveis.Classe
{
    //Criando a classe de aluno com características diferentes da classe Pessoa para demonstração da implementação da interface IPessoa
    internal class Aluno : IPessoa
    {
        public Aluno(DateTime dataNascimento)
        {
            Aniversario = dataNascimento;
        }
        public int Idade { get; private set; }

        public DateTime Aniversario { get; set; }
        public void ComemorarAniversario()
        {
            DateTime hoje = DateTime.Now;
            Idade = hoje.Year - Aniversario.Year;

            if (hoje.Month < Aniversario.Month || (hoje.Month == Aniversario.Month && hoje.Day < Aniversario.Day))
                Idade--;
        }
        public void Hello(string msg)
        {
            Console.WriteLine(@$"Olá, sou a classe Aluno! msg -> {msg}");
        }       
    }
}
