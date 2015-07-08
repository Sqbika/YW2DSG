using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Tiles
{
    public class GenericTile : Gravity
    {
        private Vector2 position = new Vector2(0, 0); //Calculated from Top-Left of the Tile
        private Rectangle collisionBox = new Rectangle(0, 0, 8, 8);
        private string name = null;
        private Texture2D textureName = null;
        private int tileID = 0;
        //TODO: Add ItemDroppedOnRemove variable
        private int hardness = 0;
        private int requiredTool = 0;
        private int requiredToolLevel = 0;

        #region Publicity
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Rectangle CollisionBox
        {
            get { return collisionBox; }
            set { collisionBox = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Texture2D TextureName
        {
            get { return textureName; }
            set { textureName = value; }
        }

        public int TileID
        {
            get { return tileID; }
            set { tileID = value; }
        }

        /*
         public *GENERICITEMENTITY* ItemDroppedOnRemove
         {
            get { return itemDroppedOnRemove; }
            set { itemDroppedOnRemove = value; }
         }
         */

        public int Hardness
        {
            get { return hardness; }
            set { hardness = value; }
        }

         public int RequiredTool
         {
            get { return requiredTool; }
            set { requiredTool = value; }
         }

        public int RequiredToolLevel
        {
            get { return requiredToolLevel; }
            set { requiredToolLevel = value; }
        }
        #endregion
    }
}
