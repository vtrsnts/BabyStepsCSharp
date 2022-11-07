using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipos_e_Variaveis.Enum;
using Tipos_e_Variaveis.Interface;

namespace Tipos_e_Variaveis.Classe
{
    // Classe são domínios representados em uma aplicação para atender um determinado negócio
    // usamos a abstração do mundo real buscando extrair comportamentos e características de um domínio para escrever de forma organizada uma classe
    // podem ter atributos, propriedades, métodos 
    internal class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Mes MesNascimento { get; set; }
        public int DiaNascimento { get; set; }
        public void ComemorarAniversario()
        {
            if ((int)MesNascimento == DateTime.Now.Month && DiaNascimento == DateTime.Now.Day)
                Idade++;
        }
        public void Hello(string msg)
        {
            Console.WriteLine(@$"Olá, sou a classe Pessoa! msg -> {msg}");
        }
    }
}
