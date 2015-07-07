using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Map
{
    public class GenericTile : Gravity
    {
        private Vector2 position; //Calculated from Top-Left of the Tile
        private Rectangle collisionBox;
        private string name;
        private Texture2D textureName;
        private int tileID;
        //TODO: Add ItemDroppedOnRemove variable
        private int hardness;
        //TODO: Add requiredTool variable
        private int requiredToolLevel;

        public GenericTile()
        {
            position = new Vector2(0, 0);
            collisionBox = new Rectangle(0, 0, 8, 8);
            name = null;
            textureName = null;
            tileID = 0;
            //itemDroppedOnRemove = null;
            hardness = 0;
            //requiredTool = nothing;
            requiredToolLevel = 0;
        }

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
         public *GENERICITEM* ItemDroppedOnRemove
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

        /*
         public *GENERICTOOL* RequiredTool
         {
            get { return requiredTool; }
            set { requiredTool = value; }
         }
         */

        public int RequiredToolLevel
        {
            get { return requiredToolLevel; }
            set { requiredToolLevel = value; }
        }
        #endregion
    }
}
