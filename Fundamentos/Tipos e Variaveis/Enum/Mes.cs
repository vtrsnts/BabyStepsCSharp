using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_e_Variaveis.Enum
{
    // O tipo enumerável serve para utilizarmos um domínio no programa, não necessariamente precisa ser armazenado em um banco de dados,
    // possui a característica de traduzir números em texto facilitando o entendimento de "Magic Numbers" que o desenvolvedor possa vir a utilizar.
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
