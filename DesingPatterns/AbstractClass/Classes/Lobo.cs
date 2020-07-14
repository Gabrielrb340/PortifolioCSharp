using DesingPatterns.AbstractClass.Abstracoes;
using DesingPatterns.AbstractClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractClass.Classes
{
    public class Lobo : AnimalSelvagem, IComportamentoCanino , IComportamentoCaninoSelvagem // segregação de interface
    {
        public void Latir() // sim Lobos latem 
        {
            Console.WriteLine("O lobo raramente late , mais neste momento ele está latindo");
        }

        public void Morder()
        {
            Console.WriteLine("O lobo está mordendo");
        }

        public void Rosnar()
        {
            Console.WriteLine("O lobo está rosnando");
        }

        public void Uivar()
        {
            Console.WriteLine("O lobo está Uivando");
        }
        public override void Cacar()
        {
            Console.WriteLine("O lobo está caçando");
        }
        public override void Matar(string animal)
        {
            Console.WriteLine("O lobo matou o "+animal);

        }
    }
}
