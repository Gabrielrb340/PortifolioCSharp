using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractClass.Abstracoes
{
    public abstract class AnimalSelvagem: Animal
    {
        public  virtual void Cacar()
        {
            Console.WriteLine("O animal selvagem esta caçando");
        }
        public virtual void Matar(string animal)
        {
            Console.WriteLine("O animal selvagem matou o(a) "+animal);
        }
    }
}
