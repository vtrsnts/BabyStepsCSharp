using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_e_Variaveis.Interface
{
    // Utilizamos Interface para definirmos um padrão esperado de uma classe ou struct
    // Escrevemos um "Contrato" onde toda classe que implementar deverá seguir o formato definido na interface
    // Na interface não definimos a regra de negócio e sim a estrutura que nossas classes deverão seguir para atingir um objetivo
    // Nos permite gerar uma abstração da classe no programa, substituindo a dependência de código atrelado a um tipo de classe específico
    // por uma interface nos possibilitando o a reutilização do código por outras classes que possuam a mesma interface. 

    internal interface IPessoa
    {
        // toda classe que implementar essa interface deverá ter o método "ComemorarAniversario" sem passagem de parâmetros e sem retorno;
        void ComemorarAniversario();
        void Ola(string msg);
        public string Nome { get; set; }
    }
}
