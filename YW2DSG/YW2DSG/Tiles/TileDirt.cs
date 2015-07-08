using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG.Tiles
{
    class TileDirt : GenericTile
    {
        public TileDirt(Vector2 position)
        {
            ShouldGravity = false;
            Position = position;
            Name = "Dirt";
            TileID = 1;
            TextureName = TextureManager.GetTextureFromID(TileID);
            Hardness = 2;
            RequiredTool = 2;
            RequiredToolLevel = 1;
        }
    }
}
