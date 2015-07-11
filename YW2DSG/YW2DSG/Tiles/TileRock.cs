using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace YW2DSG.Tiles
{
class TileRock : GenericTile
{
public TileRock(Vector2 position)
{
ShouldGravity = false;
Position = position;
Name = "Rock";
TileID = 2;
TextureName = TextureManager.GetTextureFromID(TileID);
ItemDroppedOnRemove = Items.ItemRock();
Hardness = 4;
RequiredTool = 1;
RequiredToolLevel = 2;
}
}
}
