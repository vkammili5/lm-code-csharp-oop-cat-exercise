using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat() : base(averageHeight: 23, setting: "domestic")
        {
              
        }
        public override string Eat()
        {
            return "Purrrrrrr";
        }

    }
    
}
