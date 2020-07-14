using DesingPatterns.AbstractClass.Abstracoes;
using DesingPatterns.AbstractClass.Interfaces;
using System;

namespace DesingPatterns.AbstractClass
{
    public class Cachorro : AnimalDomestico, IComportamentoPadrao, IComportamentoCanino
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override void Beber(string liquido)
        {
            Console.WriteLine($"O cachorro esta bebendo {liquido}");
        }

        public void Brincar()
        {
            Console.WriteLine("O cachorro esta brincando!");
        }

        public override void Comer()
        {
            Console.WriteLine("O cachorro esta comendo comendo!");
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro esta correndo!");
        }

        public void Latir()
        {
            Console.WriteLine("O cachorro esta latindo!");
        }

        public void Morder()
        {
            Console.WriteLine("O cachorro esta mordendo!");
        }

        public void Rosnar()
        {
            Console.WriteLine("O cachorro esta rosnando!");
        }
    }
}
