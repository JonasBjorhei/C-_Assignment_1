﻿using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Items
{
    internal class Item
    {

       public string itemName { get; set; }
       public int requiredLevel { get; set; }

        public HeroClass.Slot slot { get; set; }



    }
}
