using System.Drawing;
using Tipos_e_Variaveis.Classe;
using Tipos_e_Variaveis.Enum;
using Tipos_e_Variaveis.Interface;
using Tipos_e_Variaveis.Struct;

namespace Tipos
{
    //O código abaixo tem o entendimento do conceito abordado portanto não retrata as melhores práticas de desenvolvimento e sim do conceito em questão!
    public class Program
    {
        public delegate void ExemploDelegate(string msg);

        public static void Main(string[] args)
        {

            //Olá, vamos aprender sobre tipos e variáveis!
            //  Objetivo:
            //      -> Conceito de tipo de dado.
            //      -> Conceito de variável.

            //Tipo de dado:
            //  É definição da estrutura e o comportamento de qualquer dado.
            //  É uma característica, identificação, definição do padrão do tipo de informação em que o programa realiza algum processamento.
            //  É necessário sabermos qual tipo de informação o programa ira utilizar para podermos realizar operações ou processamento de forma adequada.
            //Exemplos:
            //  Nome, idade, data de nascimento, Km, situação pagamento, chassi, cor, notas

            //Tipo de valor:
            //  Temos a seguinte classificação de tipos simples, enums, struct, nullable, tuple (ValueTuple).
            //  Todo tipo de valor é armazenado na memória Stack  

            //Tipos de valor simples:
            //  Integral, char, floating-point, Boolean

            int idade = 10;
            char genero = 'M';
            decimal preco = 10.2m;
            bool stAtivo = true;

           //Tipos de valor enum:
           //   São variaveis constantes representadas por um enumerável

            var mes = Mes.Abril;
           
           //Tipos de valor struct:
           //   São semelhantes a classe de objetos, porém existem as seguintes diferenças:
           //   Não há herança em struct
           //   É passada por cópia e não referência

            ExemploStruct exemploStruct = new ExemploStruct();
            exemploStruct.Calcular();
            exemploStruct.Origem = "Teste";

           //Tipos de valor nullable:
           //   Possibilita o uso de nulo em tipos que não permitem valores nulos (tipos primitivos)
           //   Podemos utilizar o Nullable em tipos que assumem valores default porém não queremos esse tipo 
            
            int? nota = null; // default do tipo inteiro seria zero como declaramos que ele é um valor nullable conseguimos fazer uma atribuição nula de um tipo int 
            if (!nota.HasValue)
                nota = 10;

            //Tipos de valor tuple:
            //  São variáveis que podem compor n valores em sua estrutura
            //  Uma forma prática de compor dados desde que não fique muito extenso 
            //  Gosto de fazer uma mera comparação de que tupla lembra a representação de uma linha de dados retornado
            //  de um select em um banco de dados, cada campo possui seu tipo de dados, assim como na tupla temos a definição do tipo de dado e sua composição. 

            ValueTuple<string, int, bool> tuplaA = new ValueTuple<string, int, bool>("tupla", 1, true);
            var nome = tuplaA.Item1;
            var id = tuplaA.Item2;
            var ativo = tuplaA.Item3;

            (string, int, bool) tuplaB = (nome, id, ativo);
            var nomeTuplaB = tuplaB.Item1;

            (string Nome, int Id, bool Ativo) tuplaC = (nome, id, ativo);
            var nomeTuplaC = tuplaC.Nome;
            var idTuplaC = tuplaC.Id;
            var ativoTuplaC = tuplaC.Ativo;

            //Tipo de referência:
            //  Temos a seguinte classificação classe, interface, array, delegate
            //  Todo tipo de referência é armazenado na memória Heap

            //Tipo de referência classe:
            //  Usamos para representar um domínio do contexto da aplicação para atribuição de valores ou funções que realizam processamento da informação
            
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "John Doe";
            pessoa.Idade = 20;
            pessoa.MesNascimento = Mes.Outubro;
            pessoa.DiaNascimento = 05;
            
            //Tipo de referência interface:
            //  Utilizado para definirmos contrato para uma classe ou struct
          
            IPessoa aluno = new Aluno(new DateTime(2000,11,5));
            VerificarAniversario(pessoa);
            VerificarAniversario(aluno);
            //Tipo de referência array:
            //  Utilizado para agrupar variáveis de mesmo tipo semelhante a uma lista

            int[] numerosSorteio = { 10, 20, 30, 40 };


            //Tipo de referência delegate:
            //  Declaração de um ponteiro de forma externa através de uma assinatura de método.
            //  Muito utilizado quando precisamos passar o controle, responsabilidade de algo, para algo externo que a classe não tem conhecimento de como fazer.
            //  Uso bastante comum em aplicações que utilizam eventos, UserControls, onde temos o uso de componentes. 
            ExemploDelegate exemploDelegatePessoa = pessoa.Hello;
            ExemploDelegate exemploDelegateAluno = aluno.Hello;

            exemploDelegatePessoa("Delegate para classe Pessoa");
            exemploDelegateAluno("Delegate para classe Aluno");

            //Tipo dynamic:
            //  É um objeto que não há validação de seu tipo penas em runtime é resolvido o tipo, atributos, métodos, operadores.
            //  Muito utilizado na estrutura MVC do .net em View.Bag
            //  Necessário atenção ao manipular pois há possibilidade de null ou mudanças de tipo podendo gerar erros em tempo de execução
            //  Podemos usar o tipo dynamic ao serializar dados retornados de um json(Api) ou arquivos externos sem a necessidade de criarmos a escrita das classes em nossa aplicação.

            
            dynamic exemploDynamic = 100; //definindo tipo inteiro para o tipo dynamic
            exemploDynamic = "uhuuuu mudamos para tipo string";
            
            exemploDynamic = false; //definindo tipo boolean
             
            exemploDynamic = pessoa; // fazendo referência ao objeto pessoa

             
            string nomePessoa = exemploDynamic.Nome;//acessando o atributo nome
            try
            {
                string erro = exemploDynamic.VaiDarErroMasAceitaQualquerTextoDinamico; //acessando um atributo inexistente gerando erro
            }
            catch (Exception erro) //capturando erro
            {
                Console.WriteLine(erro.Message); //exibindo a mensagem do erro    
            }

            //Pontos importantes relacionado a Stack e Heap
            //  Quando usamos tipos de valores e criamos uma nova variável utilizando uma existente é passado uma cópia da variável ou seja podemos alterar os valores sem alterar o valor origem
            //  Quando usamos tipos de referência e criamos uma nova variável assumindo um objeto existente é passado a referência do objeto ou seja tudo que alterarmos nesse objeto ra refletir em sua origem.
            
            //Tipos de Valores
            int subtotal = 10; // atribuindo 10 a uma variável do tipo de valores 
            int total = subtotal; // atribuindo uma cópia da variável;
            total = total + 5;// realizando alteração da cópia da variável onde ira assumir o valor de 15 e a  variável anterior "subtotal" preserva seu valor 10  

            //Tipos de Referência
            Pessoa novaPessoa = pessoa; // criamos uma Referência de pessoa
            novaPessoa.Nome = "John No Arm"; // alteramos o nome
            string nomeNovo = pessoa.Nome; // fazemos a leitura da referência origem e como mágica vimos que alterou para John No Arm também
            //isso ocorre exatamente por ser um tipo de referência ou seja o ponteiro que é armazenado na Stack do objeto em questão nada mais é do que o mesmo identificador do objeto origem armazenado na Heap. 

            
        }

        //Método com uso de interface possibilita a utilização por todas as classes que tem a interface IPessoa com essa estrutura possibilitamos o desacoplamento de código.

        internal static void VerificarAniversario(IPessoa pessoa) 
        {
            pessoa.ComemorarAniversario();
        }
    }  
}