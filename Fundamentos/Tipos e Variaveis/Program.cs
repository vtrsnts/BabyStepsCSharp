using System.Drawing;

namespace Tipos_e_Variaveis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Olá, vamos aprender sobre tipos e variáveis!");
            Console.WriteLine("Objetivo:");
            Console.WriteLine("-> Conceito de tipo de dado.");
            Console.WriteLine("-> Conceito de variável.");
            Console.ReadLine();
            Console.WriteLine("Tipo de dado:");
            Console.WriteLine("     É definição da estrutura e o comportamento de qualquer dado.");
            Console.WriteLine("     É uma característica, identificação, definição do padrão do tipo de informação em que o programa realiza algum processamento.");
            Console.WriteLine("     É necessário sabermos qual tipo de informação o programa ira utilizar para podermos realizar operações ou processamento de forma adequada.");
            Console.WriteLine("Exemplos:");
            Console.WriteLine("     Nome, idade, data de nascimento, Km, situação pagamento, chassi, cor, notas");
            Console.ReadLine();
            Console.WriteLine("Tipo de valor:");
            Console.WriteLine("     Temos a seguinte classificação de tipos simples, enums, struct, nullable, tuple.");
            Console.ReadLine();
            Console.WriteLine("Tipos de valor simples:");
            Console.WriteLine("    Integral, char, floating-point, Boolean");

            int idade = 10;
            char genero = 'M';
            decimal preco = 10.2m;
            bool stAtivo = true;

            Console.ReadLine();

            Console.WriteLine("Tipos de valor enum:");
            Console.WriteLine("    São variaveis constantes representadas por um enumerável");

            string mes = Mes.Janeiro.ToString();

            Console.ReadLine();
            Console.WriteLine("Tipos de valor struct:");
            Console.WriteLine("    São semelhantes a classe de objetos, porém existem as seguintes diferenças:");
            Console.WriteLine("    Não há herança em struct");
            Console.WriteLine("    É passada por cópia e não referência");
            Console.ReadLine();
            Console.WriteLine("Tipos de valor nullable:");
            Console.WriteLine("    Possibilita o uso de nulo em tipos que não permitem valores nulos (tipos primitivos)");
            Console.ReadLine();
            Console.WriteLine("Tipos de valor tuple:");
            Console.WriteLine("    São variáveis que podem compor n valores em sua estrutura");
            Console.ReadLine();
            Console.WriteLine("Tipo de referência:");
            Console.WriteLine("     Temos a seguinte classificação classe, interface, array, delegate");
            Console.ReadLine();
            Console.WriteLine("Tipo de referência classe:");
            Console.WriteLine("     Usamos para representar um domínio do contexto da aplicação para atribuição de valores ou funções que realizam processamento da informação");
            Console.ReadLine();
            Console.WriteLine("Tipo de referência interface:");
            Console.WriteLine("     Utilizado para definirmos contrato para uma classe ou struct");
            Console.ReadLine();
            Console.WriteLine("Tipo de referência array:");
            Console.WriteLine("     Utilizado para agrupar variáveis de mesmo tipo semelhante a uma lista");
            Console.ReadLine();
            Console.WriteLine("Tipo de referência delegate:");
            Console.WriteLine("     Declaração de uma assinatura de forma genérica utilizada em encapsulamento");
            Console.ReadLine();
            Console.WriteLine("Tipo dynamic:");
            Console.WriteLine("     É um objeto que não há validação de seu tipo penas em runtime é resolvido o tipo, atributos, métodos, operadores.");
        }      
    }
    enum Mes
    {
        Janeiro = 1,
        Fevereiro,
        Marco,
        Abril,
        Maio,
        Junho,
        Julho,
        Agosto,
        Setembro,
        Outubro,
        Novembro,
        Dezembro
    }
}