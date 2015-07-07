using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Items
{
    class GenericArmor : GenericItem
    {
        private int defense;
        private int armorType;

        public GenericArmor()
        {
            defense = 0;
            armorType = 0;
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public int ArmorType
        {
            get { return armorType; }
            set { armorType = value; }
        }
    }
}
