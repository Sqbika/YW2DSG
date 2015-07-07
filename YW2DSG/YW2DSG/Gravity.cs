using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG
{
    public class Gravity
    {
        private int mass;
        private Vector2 size;
        private bool isPlayer;

        private bool initialized = false;

        private List<object> gravitedObjects;

        public Gravity()
        {
            mass = 1; //Default: 1"kg"
            size = new Vector2(8, 8); //Default: 1 block
            isPlayer = false; //Default: false;
        }

        public int Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        public Vector2 Size
        {
            get { return size; }
            set { size = value; }
        }

        public bool IsPlayer
        {
            get { return isPlayer; }
            set { isPlayer = value; }
        }

        public bool InitializeGravity()
        {
            gravitedObjects = new List<object>();
            initialized = true;
            return false;
        }

        public List<object> GravitedObject
        {
            get { return gravitedObjects; }
        }


        public void AddObjectToGravity(object Thing)
        {
            if(initialized)
            {
                gravitedObjects.Add(Thing);
            }
        }
    }
}
