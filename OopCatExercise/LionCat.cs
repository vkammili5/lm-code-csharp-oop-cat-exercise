﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        public LionCat() : base(averageHeight: 1100, setting: "wild")
        {

        }
        public override string Eat()
        {
            return "Roar!!!!";
        }

    }
}
