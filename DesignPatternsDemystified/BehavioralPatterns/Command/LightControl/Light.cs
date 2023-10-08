﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Command.LightControl
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }
    }
}
