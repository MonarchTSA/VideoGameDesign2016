using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{

    //Mobs are monsters controlled by AI
    public abstract class Mob : Monster
    {
        public AI ai { get; set; }
    }
}
