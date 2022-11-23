using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipos_e_Variaveis.Classe;
using Tipos_e_Variaveis.Extension;

namespace Tipos_e_Variaveis.ListArray
{
    internal class ExemploLista
    {
        public ExemploLista()
        {
            ListaAluno = new List<Aluno>();
            ListaInteiros = new List<int>();
            ListaPessoa = new List<Pessoa>();
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int iNegativo = i * -1;
                Pessoa pessoa = new Pessoa();
                pessoa.DataNascimento = DateTime.Now.AddYears((random.Next(10, 60) * -1));
                pessoa.GerarNomeAleatorio();
                ListaPessoa.Concat(new[] { pessoa });
                ListaInteiros.Add(random.Next(1, 1000));

                Aluno aluno = new Aluno(DateTime.Now.AddYears((random.Next(10, 60) * -1)));
                aluno.GerarNomeAleatorio();
                ListaAluno.Add(aluno);
            }
        }
        public IEnumerable<Pessoa> ListaPessoa { get; set; }
        public List<int> ListaInteiros { get; set; }
        public List<Aluno> ListaAluno { get; set; }

        public List<Aluno> FiltrarAlunoHardCode(int idade, string nome)
        {
            List<Aluno> listaRetorno = new List<Aluno>();

            //podemos utilizar a estrutura de repetição foreach em uma lista
            //o exemplo abaixo está apenas exemplificando uma estrutura de busca utilizado foreach *** claro que existem forma mais apropriadas

            foreach (var aluno in ListaAluno)
            {
                if (aluno.Idade == idade || aluno.Nome == nome)
                    listaRetorno.Add(aluno);//estamos adicionando o item a uma lista de retorno com critério passado no parâmetro
            }
            return listaRetorno;
        }
        public List<Aluno> FiltrarAluno(int idade, string nome)
        {
            //IEnumerable descreve o comportamento a ser processado pela lista
            IEnumerable<Aluno> listaRetorno = ListaAluno.Where(c => c.Idade == idade || c.Nome == nome);
            //ao converter um IEnumerable para List temos a implementação do comportamento contido no IEnumerable
            return listaRetorno.ToList();
        }
        public void OrdernarListaInteiro()
        {
            //IEnumerable descreve o comportamento a ser processado pela lista
            var IEnumerableOrdenado = ListaInteiros.OrderBy(c => c);
            //ao converter um IEnumerable para List temos a implementação do comportamento contido no IEnumerable
            ListaInteiros = IEnumerableOrdenado.ToList();
        }

        public void OrdernarListaInteiroHardCode()
        {
            //podemos usar uma estrutura de repetição para realizar operações de ordenação *** claro que existem forma mais apropriadas 
            int total = ListaInteiros.Count;
            for (int i = 0; i < total - 1; i++)
            {
                int numeroAtual = ListaInteiros[i];
                int proximoNumero = ListaInteiros[i + 1];
                if (numeroAtual < proximoNumero)
                {
                    ListaInteiros[i] = proximoNumero;
                    ListaInteiros[i + 1] = numeroAtual;
                    i = -1;
                }
            }
        }
    }
}
