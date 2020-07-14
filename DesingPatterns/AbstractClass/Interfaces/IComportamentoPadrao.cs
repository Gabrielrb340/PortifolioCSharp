using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractClass.Interfaces
{
    public interface IComportamentoPadrao: IComportamento
    {
        void Correr();
        void Brincar();
    }
}
