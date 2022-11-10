using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_e_Variaveis.Static
{
    //Para facilitar a visualização as classes estão em um único arquivo lembrando que não é a maneira correta de gerar classes!! 
    //Modificador static tem o objetivo de não permitir a instância, podemos usar o modificador static em classes, propriedades, métodos.
    //Modificador static em classe -> usamos para impedir a instância da classe permitindo o acesso unicamente por meio da "chamada" direta da classe
    //Ao declaremos uma classe static todos o conteúdo da classe precisa ser static (métodos, propriedades) pois estamos impedindo a instância da classe e
    //não há como acessar o conteúdo de instância nesse cenário  
    public static class ValidadorPessoa
    {      
        public static bool ValidarCPF(string cpf) 
        {
            //lógica aqui 
            return true;
            
        }
        
    }
    //Modificador static em métodos, variáveis
    // Quando a classe não é static e tem propriedades, métodos static devemos pensar que temos uma separação em duas visões dessa classe uma voltada para instância e outra para static
    // Temos uma separação pois todos os tipos  "static" não enxergam  os tipos de "Instância"
    // já os tipos de instância tem acesso aos tipos static da classe podendo utilizar os métodos estáticos e alterar propriedades
    // estáticas da classe essa abordagem requer muito cuidado pois afeta de forma global a classe.  
    public class ValidadorTexto 
    {
        public static string _texto;
        public string Nome { get; set; }
        public static bool Validar(string texto)
        {
            _texto = @$"{texto} -> Validar";
            //lógica aqui
            //ValidarNome();//por não termos uma instância definida não conseguimos acessar os tipos de instância ValidarNome e Nome  
            //Nome = "Teste";
            return true;
        }
        public bool ValidarNome() 
        {
            Validar(Nome);//conseguimos de dentro de uma instância acessar um tipo static. 
            _texto = Nome; // devemos tomar cuidado ao manipular propriedades estáticas de uma classe através de instância pois a informação ira ser alterada de forma global.  
            //lógica aqui
            return !Nome.Contains("123");
        }
    }


}
