using DesingPatterns.AbstractClass.Abstracoes;
using DesingPatterns.AbstractClass.Classes;
using DesingPatterns.AbstractClass.Interfaces;

namespace DesingPatterns.AbstractClass
{
    public class AbstractClassMain
    {
        static void Main(string[] args)
        {
            //A classe animal é uma abstração de algo do mundo real , ou seja , a classe abstrata consegue receber qualquer tipo de animal de estimação , porem se eu tentar por exemplo associar um animal selvagem
            // não estaria de acordo com o  a realidade 
            AnimalDomestico animal = new Gato("Anakin");// Associando a classe concreta ou seja a implementação de um determinado animal , observa-se que não é possivel instanciar um lobo pois ele é um animal selvagem
            animal.Beber("Água");
            animal = new Cachorro("Kako");// Novamente associando a classe concreta ou seja a implementação de um determinado animal
            animal.Beber("Agua");

            /// Quando se instancia uma interface você garante o uso somente de sua implementação , cachorro e gato tem comportamento distintos ,porem tambem tem comportamentos semelhantes 
            /// assim independente da instancia a ação sera executada
            IComportamentoPadrao animalComportamentoPadrao = new Cachorro("Nina");
            animalComportamentoPadrao.Brincar(); // Cachorros sabem brincar
            //Mudando a instancia de animalComportamentoPadrao para ser um gato inicialmente erá um cachorro
            animalComportamentoPadrao = new Gato("Apolo");
            animalComportamentoPadrao.Brincar();// Gatos assim como cachorros sabem brincar.

            IComportamento comportamentoGenerico = animalComportamentoPadrao; /// interface em de nivel mais generico possivel como a interface comportamento não tem nada implementado para usar os metodos de classes derivadas seria necessario uma conversão;
            ((IComportamentoPadrao)comportamentoGenerico).Brincar();
            comportamentoGenerico = animalComportamentoPadrao;
            //((IComportamentoCanino)comportamentoGenerico).Latir(); /// essa linha soltaria um erro pois na é a instancia de um gato e o gato não late

            AnimalDomestico animalA = new Cachorro("Kako");//Valido
            //animalA = new Lobo(); invalido pois animal selvagem não é um animal domestico
            Animal AnimalGenerico = new Cachorro("KaKo");
            AnimalGenerico = new Gato("Apolo");
            AnimalGenerico = new Onca();
            AnimalGenerico = new Lobo();
            //Resumo
            //Quanto mais generico for sua abstração menos metodos estaram disponiveis 


        }
    }
}
