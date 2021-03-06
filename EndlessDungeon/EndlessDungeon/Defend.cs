﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessDungeon
{
    public class Defend : Action, IBuff
    {

        public Monster Sender { get; set; }
        public int Length { get; set; }
        public override string Message
        {
            get
            {
                return Sender.Name + " defended!";
            }
        }

        public Defend(Monster sender)
        {
            Sender = sender;
            Length = 1;
            Priority = 1;
        }

        public override void Perform()
        {
            ApplyBuff();
        }

        public void ApplyBuff()
        {
            Sender.Armor += 100;
        }

        public void RemoveBuff()
        {
            Sender.Armor -= 100;
        }
    }
}
