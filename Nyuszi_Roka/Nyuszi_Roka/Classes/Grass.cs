using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszi_Roka.Classes
{
    public sealed class Grass : AbstractEntity
    {
        private int tapertek = 0;
        public int Tapertek
        {
            get
            {
                return tapertek;
            }
            set
            {
                tapertek = value;
            }
        }
        public override void Fejlodik(int n)
        {
            if (Tapertek<2)
            {
                Tapertek+= n;
            }
        }
        public override void Csokken(int n)
        {
            if (Tapertek > 0)
            {
                Tapertek-= n;
            }
        }
        public Grass(string name = "G", int tapertek = 0) : base(name)
        {
            Tapertek = tapertek;
        }

        public override string ToString()
        {
            return this.Name + this.Tapertek;
        }
    }
}
