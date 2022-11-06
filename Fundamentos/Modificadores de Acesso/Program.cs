using Modificadores_de_Acesso.Protected;
using Modificadores_de_Acesso.Public;

namespace Modificadores_de_Acesso
{
    //O código abaixo tem o entendimento do conceito abordado portanto não retrata as melhores práticas de desenvolvimento e sim do conceito em questão!
    internal class Program
    {
        private static int _exemploPrivado;
        static void Main(string[] args)
        {
            //Modificadores de acesso tem por objetivo garantir a visibilidade (exposição) de uma classe, struct, método, atributo, variáveis por meios de níveis.
            //No mundo real temos restrições e regras para garantir uma segurança, organização e bom convívio em sociedade,
            //já imaginou se todos pudessem entrar na sua casa, conta bancária, no banheiro enquanto toma banho seria um caos 
            //No mundo do desenvolvimento também precisamos dessas organizações para garantirmos coesão e segurança no código para não gerarmos CAOS.
            //Temos os seguintes níveis de acesso:

            //public -> Acesso de maior abrangência onde permite expor visibilidade total para todos que fizerem o uso.
            Pessoa pessoa = new Pessoa(); 
            pessoa.Nome = "John";
            //internal -> Acesso apenas a quem pertence ao mesmo projeto (assembly)
            pessoa.Idade = 25; //ao fazermos a referência em outro projeto não teremos mais acesso a esse atributo
            //private -> Acesso e manipulação apenas da classe ("criador")
            _exemploPrivado = 10;
            //protected -> semelhante ao comportamento privado porém permite que a herança tenha acesso.
            Orientador orientador = new Orientador();
            orientador.RecuperarDataCadastro();//acessando uma variável protected herdada 
        }
    }
}