using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("ChamadaNaoAsync");
        }
    }
}
