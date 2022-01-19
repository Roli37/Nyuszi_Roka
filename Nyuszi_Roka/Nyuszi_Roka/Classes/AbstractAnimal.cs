using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszi_Roka.Classes
{
    public abstract class AbstractAnimal : AbstractEntity
    {
        public AbstractAnimal(string name) : base(name)
        {
        }

        public virtual int Jollakottsag { get; set; }
        public virtual int MaxJollakottsag { get; set; }
        public override void Csokken(int n)
        {
            if (Jollakottsag>0)
            {
                Jollakottsag-= n;
            }
        }
        public override void Fejlodik(int n)
        {
            if (Jollakottsag + n <= MaxJollakottsag)
            {
                Jollakottsag += n;
            }
        }

        public override void Elpusztul()
        {
            if (Jollakottsag == 0)
            {
                //dies
            }
        }

    }
}
