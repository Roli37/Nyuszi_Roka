using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszi_Roka.Classes
{
    public sealed class Wolf : AbstractAnimal
    {

        public Wolf(string name = "W") : base(name)
        {
        }

        private int maxJollakottsag = 10;
        private int jollakottsag = 2;
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
        public override int Jollakottsag
        {
            get
            {
                return jollakottsag;
            }
            set
            {
                jollakottsag = value;
            }
        }
        public override string ToString()
        {
            return this.Name + this.Jollakottsag;
        }
    }
}
