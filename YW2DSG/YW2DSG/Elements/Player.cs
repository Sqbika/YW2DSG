using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Elements
{
    public class Player : Gravity
    {
        public Player()
        {
            Mass = 1;
            Size = new Microsoft.Xna.Framework.Vector2(8, 16);
        }

    }
}
