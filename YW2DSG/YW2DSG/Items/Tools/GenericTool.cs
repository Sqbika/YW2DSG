using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Items.Tools
{
    class GenericTool : GenericItem
    {
        private int toolType; // 1: Pickaxe / 2: Shovel /3: Axe / 0: Nothing
        private int strenght;
        private int speed;
        private int tileReach;

        public GenericTool()
        {
            toolType = 0;
            strenght = 0;
            speed = 0;
            tileReach = 0;
        }

        public int ToolType
        {
            get { return toolType; }
            set { toolType = value; }
        }

        public int Strenght
        {
            get { return strenght; }
            set { strenght = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int TileReach
        {
            get { return tileReach; }
            set { tileReach = value; }
        }
    }
}
