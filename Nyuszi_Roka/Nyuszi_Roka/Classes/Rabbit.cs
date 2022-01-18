using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszi_Roka.Classes
{
    public sealed class Rabbit : AbstractAnimal 
    {
        public Rabbit(string name = "R", int jollakottsag = 1) : base(name, jollakottsag)
        {
        }

        private int maxJollakottsag = 5;
        public override int MaxJollakottsag
        {
            get
            {
                return maxJollakottsag;
            }
            set
            {
                maxJollakottsag = value;
            }
        }
        public override string ToString()
        {
            return this.Name + this.Jollakottsag;
        }
    }
}
