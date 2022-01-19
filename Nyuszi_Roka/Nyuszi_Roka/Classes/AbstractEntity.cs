using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyuszi_Roka.Classes
{
    public abstract class AbstractEntity
    {
        public AbstractEntity(string name)
        {
            Name = name;
        }
        public virtual void Elpusztul() { }
        public virtual void Fejlodik(int n) { }
        public virtual void Csokken(int n) { }
        public string Name { get; set; }

    }
}
