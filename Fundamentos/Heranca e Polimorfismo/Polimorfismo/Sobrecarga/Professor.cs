using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Polimorfismo.Sobrecarga
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 
    //Polimorfismo -> Várias formas!
    //Polimorfismo na sobrecarca de método ocorre quando um método duas ou mais assinaturas para uma mesma ação.

    internal class Professor
    {
        public int Locomover()
        {
            int km =10;
            return km;
        }
        public int Locomover(int km)
        {         
            return km;
        }
        public int Locomover(int km, int tempo)
        {
            return km/tempo;
        }
        public int Locomover(DateTime date)
        {
            return date.Day;
        }
        public string Locomover(string origem)
        {
            return origem;
        }
        public string Locomover(string origem, string destino)
        {
            return $"{origem}->{destino}";
        }

    }
}
