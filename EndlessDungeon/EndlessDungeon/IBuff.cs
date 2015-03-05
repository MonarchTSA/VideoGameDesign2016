using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public interface IBuff
    {
        public int Length;
        public void ApplyBuff();
        public void RemoveBuff();
    }
}
