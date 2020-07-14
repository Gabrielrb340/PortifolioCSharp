using DesingPatterns.AbstractClass.Abstracoes;
using DesingPatterns.AbstractClass.Interfaces;
using System;

namespace DesingPatterns.AbstractClass.Classes
{
    public class Onca : AnimalSelvagem, IComportamentoFelino
    {
        public void Arranhar()
        {
            Console.WriteLine("A onça esta arranhando");
        }

        public void Escalar()
        {
            Console.WriteLine("A onça esta arranhando");
        }

    }
}
