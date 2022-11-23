using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_e_Variaveis.AnonymousFunction
{
    internal class ExemploAF
    {
        public ExemploAF()
        {
            var funcTemp = (string teste) => teste.ToUpper();
            var func = (string teste) =>
            {
                string texto = string.Empty;
                if (teste.Length > 10)
                    texto = teste.ToLower();
                else
                    texto = teste.ToUpper();
                return texto;
            };

            Console.WriteLine(funcTemp("olá, sou a classe exemploaf"));
            Console.WriteLine(func("OLÁ, SOU A CLASSE EXEMPLOAF!"));
           
        }
        public Func<string, string> HelloFunc = (msg) =>
        {
            return @$"Olá! msg -> {msg}";
        };

        public Action<string> HelloAction = (txt) =>
        {
            Console.WriteLine(@$"Olá! txt -> {txt}");
        };

        public Predicate<string> HelloPredicate = (msg) =>
        {
            return msg.Length == 10;
        };
    }
}
