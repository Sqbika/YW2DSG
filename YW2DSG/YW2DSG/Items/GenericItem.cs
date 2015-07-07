using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Items
{
    class GenericItem
    {
        private int maxStack;
        private string itemName;
        private Texture2D itemTexture;
        private string itemDesc;
        private Map.GenericTile tileName;


        public GenericItem()
        {
            maxStack = 128;
            itemName = null;
            itemTexture = null;
            itemDesc = null;
            tileName = null;
        }

        public int MaxStack
        {
            get { return maxStack; }
            set { maxStack = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public Texture2D ItemTexture
        {
            get { return itemTexture; }
            set { itemTexture = value; }
        }

        public string ItemDesc
        {
            get { return itemDesc; }
            set { itemDesc = value; }
        }

        public Map.GenericTile TileName
        {
            get { return tileName; }
            set { tileName = value; }
        }
    }
}
