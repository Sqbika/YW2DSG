using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Entity
{
    class GenericEntity : Gravity
    {
        private int maxHealth;

        public GenericEntity()
        {
            maxHealth = 0;
        }

        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }
    }
}
