using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(averageHeight: 1500, setting: "wild")
        {

        }
        public override string Eat()
        {
            return "Zzzzzzz";
        }

    }
}
