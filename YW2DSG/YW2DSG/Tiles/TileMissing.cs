using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Tiles
{
    class TileMissing : GenericTile
    {
        public TileMissing(Vector2 position)
        {
            ShouldGravity = false;
            Position = position;
            Name = "Missing";
            TileID = 0;
            TextureName = TextureManager.GetTextureFromID(TileID);
	    	ItemDroppedOnRemove= new Items.ItemMissing();
            Hardness = 0;
            RequiredTool = 0;
            RequiredToolLevel = 0;
        }
    }
}
