using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public abstract class Cast : Action
    {
        public int ManaCost { get; set; }
    }
}
