using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tipos_e_Variaveis.Classe;
using Tipos_e_Variaveis.Interface;

namespace Tipos_e_Variaveis.Extension
{
    //Utilizamos Extension para criarmos funções/métodos extendidas a uma classe, tipo
    //Possui um grande poder de conseguirmos realizar algo específico a um projeto ou negócio sem necessáriamente expormos para todo lugar que faz referência a classe.
    //nos possibilita criar funções extendidas a classes que são escritas por máquina sem risco de perdermos o código quando for regerado pela máquina.
    //possibilita customizar e adicionar funcionalidades a uma classe tanto de dentro da nossa estrutura quento de forma externa (pacotes)
    //Toda Extension precisa ser estática 
    internal static class FundamentosExtension
    {
        public static bool Validar(this Aluno aluno) 
        {
            //lógica de validação
            return true;
        }
        public static bool Validar(this Pessoa  pessoa, string nome)
        {
            //lógica de validação
            return true;
        }
        public static void GerarNomeAleatorio(this IPessoa pessoa) 
        {
            Random random = new Random();
            int tamanhoNome = random.Next(5, 15);
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            pessoa.Nome =  new string(Enumerable.Repeat(chars, tamanhoNome).Select(s => s[random.Next(s.Length)]).ToArray());
        }        
    }
}
