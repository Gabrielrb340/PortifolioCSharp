using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractClass.Abstracoes
{
    public abstract class Animal
    {
        public virtual void Farejar()
        {
            Console.WriteLine($"O Animal está farejando");
        }
        public virtual void Andar()
        {
            Console.WriteLine($"O Animal está andando");
        }
        public virtual void Pular()
        {
            Console.WriteLine($"O Animal está pulando");
        }
        public virtual void Avancar()
        {
            Console.WriteLine($"O Animal está avançando");
        }
        public virtual void Recuar()
        {
            Console.WriteLine($"O Animal está recuando");

        }

    }
}
