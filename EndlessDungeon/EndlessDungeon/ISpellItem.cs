using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public interface ISpellItem
    {
        public Cast Spell { get; set; }
    }
}
