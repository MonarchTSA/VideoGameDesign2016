﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public abstract class Action
    {
        public bool IsBuff { get; set; }
        public int Priority { get; set; }
        public String Name { get; set; }
        public virtual String Message { get; set; }
        public Monster Sender { get; set; }

        public abstract void Perform();
    }
}
