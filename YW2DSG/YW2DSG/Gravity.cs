using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG
{
    public class Gravity
    {
        private int mass = 1;
        private Vector2 size = new Vector2(8, 8);
        private bool isEntity = false;
        private bool shouldGravity = false;
        private bool initialized = false;
        private Textures textureManager;

        public void InitializeGravityHub(Textures textures)
        {
            textureManager = textures;
        }

        private List<object> gravitedObjects;
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

        public bool IsEntity
        {
            get { return isEntity; }
            set { isEntity = value; }
        }

        public bool ShouldGravity
        {
            get { return shouldGravity; }
            set { shouldGravity = value; }
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

        public Textures TextureManager
        {
            get { return textureManager; }
        }
    }
}
