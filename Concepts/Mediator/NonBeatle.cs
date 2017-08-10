﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class NonBeatle : Participant
    {
        public NonBeatle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
