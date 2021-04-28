using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetGame
{
    public struct Card
    {
        public enum Shape
        {
            Squiggle,
            Oval,
            Diamond            
        }
        
        public enum Color
        {
            Red,
            Purple,
            Green
        }
        
        public enum Shading
        {
            Solid,
            Striped,
            Outlined
        }

        public enum Number
        {
            One,
            Two,
            Three
        }
    }
}
