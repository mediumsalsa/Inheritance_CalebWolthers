﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_CalebWolthers
{
    internal class Entities : GameObjects
    {

        public HealthSystem healthSystem;


        public Entities()
        { 
            healthSystem = new HealthSystem();
        }

    }
}
