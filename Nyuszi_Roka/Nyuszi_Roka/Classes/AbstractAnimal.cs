using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszi_Roka.Classes
{
    public abstract class AbstractAnimal : AbstractEntity
    {
        public AbstractAnimal(string name, int jollakottsag) : base(name)
        {
            Jollakottsag = jollakottsag;
        }

        public override void Fejlodik(int n)
        {
            if (Jollakottsag + n <= MaxJollakottsag)
            {
                MaxJollakottsag += n;
            }
        }
        public virtual int MaxJollakottsag { get; set; }
        public override void Csokken()
        {
            if (Jollakottsag>0)
            {
                Jollakottsag--;
            }
        }
        public override void Elpusztul()
        {
            if (Jollakottsag == 0)
            {
                
            }
        }

        private int jollakottsag;
        public int Jollakottsag
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
    }
}
