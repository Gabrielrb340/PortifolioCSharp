using DesingPatterns.AbstractClass.Abstracoes;
using DesingPatterns.AbstractClass.Interfaces;
using System;

namespace DesingPatterns.AbstractClass
{
    public class Gato : AnimalDomestico, IComportamentoPadrao, IComportamentoFelino, IComportamentoFelinoEstimacao
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override void Beber(string liquido)
        {
            Console.WriteLine($"O Gato esta bebendo {liquido}");
        }
        public void Arranhar()
        {
            Console.WriteLine("Gato esta arranhando!");
        }

        public void Brincar()
        {
            Console.WriteLine("Gato esta brincandp!");
        }

        public override void Comer()
        {
            Console.WriteLine("Gato esta comendo bebendo!");
        }

        public void Correr()
        {
            Console.WriteLine("Gato esta correndo!");
        }

        public void Escalar()
        {
            Console.WriteLine("Gato esta escalando!");
        }

        public void Miar()
        {
            Console.WriteLine("Gato esta miando!");
        }

        public void Ronronar()
        {
            Console.WriteLine("Gato esta roronando!");
        }
    }
}
