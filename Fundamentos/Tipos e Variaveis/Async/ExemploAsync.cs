using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipos_e_Variaveis.Classe;
using Tipos_e_Variaveis.Extension;
using Tipos_e_Variaveis.ListArray;

namespace Tipos_e_Variaveis.Async
{
    internal class ExemploAsync
    {
        internal async static Task ChamadaAsync()
        {
            Console.WriteLine("ChamadaAsync");
            await Task.Delay(TimeSpan.FromMilliseconds(800));
        }
        internal static void ChamadaNaoAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(400));
                Console.WriteLine("ChamadaNaoAsync");
            }
        }
        internal static void ListaParalela(List<Aluno> listaAluno)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            Parallel.ForEach(listaAluno, new ParallelOptions { MaxDegreeOfParallelism = 2 }, aluno =>
            {
                int indiceAluno = listaAluno.IndexOf(aluno);
                Console.WriteLine(@$"ListaParalela ->{indiceAluno} = {aluno.Nome}");
                aluno.Validar();
            });
        }

    }
}
