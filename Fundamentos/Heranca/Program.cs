
namespace Heranca
{
    //O código abaixo tem o entendimento do conceito abordado portanto não retrata as melhores práticas de desenvolvimento e sim do conceito em questão!
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Herança -> permite que uma classe herde atributos,propriedades, métodos de uma classe já existente.
            //Objetivo de termos herança é facilitar e dinamizar o desenvolvimento possipilitando o reuso de classes.
            
            //herança simples -> ocorre quando uma classe base é herdada para uma única classe derivada 
            Heranca.Simples.ProfessorDoutor herancaSimplesProfessorDoutor = new Heranca.Simples.ProfessorDoutor();
            //A variável herancaSimples é uma classe do tipo ProfessorDoutor que é derivada  da classe base Professor
            herancaSimplesProfessorDoutor.Idade = 30;// esse atributo pertence a classe base Professor
            herancaSimplesProfessorDoutor.Nome = "John";// esse atributo pertence a classe base Professor
            herancaSimplesProfessorDoutor.NomeDoutorado = "Segurança";// esse atributo pertence a classe ProfessorDoutor
            
            //herança hierárquica -> ocorre quando uma classe base possui mais de uma classe derivada.
            Heranca.Hierarquica.ProfessorDoutor herancaHierarquicaProfessorDoutor = new Hierarquica.ProfessorDoutor();
            Heranca.Hierarquica.ProfessorOrientador herancaHierarquicaProfessorOrientador = new Hierarquica.ProfessorOrientador();
            //a classe base Heranca.Hierarquica.Professor é herdada nas duas classes Heranca.Hierarquica.ProfessorDoutor e Heranca.Hierarquica.ProfessorOrientador criando uma hierarquia.
            
            //herança Multinível -> ocorre quando realizamos a herança de uma classe já derivada.
            Heranca.Multinivel.ProfessorDoutor herancaMultinivelProfessorDoutor = new Multinivel.ProfessorDoutor();
            Heranca.Multinivel.ProfessorOrientador herancaMultinivelProfessorOrientador = new Multinivel.ProfessorOrientador();
            //a classe Heranca.Multinivel.ProfessorDoutor é derivada da classe base Heranca.Multinivel.Professor
            //a classe Heranca.Multinivel.ProfessorOrientador é derivada da classe derivada Heranca.Multinivel.ProfessorDoutor que é derivada da classe base Heranca.Multinivel.Professor

            //herança Múltipla --> é o conceito de uma classe herdar diretamente duas ou mais classes, no c# não existe a possibilidade de uma classe herdar diretamente mais de uma classe.
            //Para conseguirmos o comportamento de herança multipla temos que utilizar interfaces pois é permitido no c# uma classe implementar n interfaces 
            Heranca.Multipla.ProfessorOrientador herancaMultiplaProfessorOrientador = new Heranca.Multipla.ProfessorOrientador();
            herancaMultiplaProfessorOrientador.AvaliarProfessor();// implementação de IDiretor
            herancaMultiplaProfessorOrientador.Idade = 25;// implementação de IProfessor
            herancaMultiplaProfessorOrientador.Nome = "John";// implementação de IProfessor
            herancaMultiplaProfessorOrientador.NomeDoutorado = "Segurança"; //Herança da classe Heranca.Multipla.ProfessorDoutor
            herancaMultiplaProfessorOrientador.CPF = "100.200.300-88"; //Herança da classe Heranca.Multipla.ProfessorDoutor
            herancaMultiplaProfessorOrientador.SalaOrientacao = "Sala - 02"; // atributo da classe  Heranca.Multipla.ProfessorOrientador
            //vemos que existe a possibilidade de atribuirmos um comportamento múltiplo para a classe Heranca.Multipla.ProfessorOrientador
        }
    }
}