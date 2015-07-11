using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace YW2DSG.Items
{
	class ItemDirt : GenericItem
	{
		public ItemDirt()
		{
			MaxStack = 128;
			ItemName = "Dirt Tile";
			ItemID = 1;
			ItemTexture = TextureManager.GetTextureFromID(ItemID);
			ItemDesc = "''It's just a simple block of a dirt''";
			TileName = Tiles.TileDirt();
		}
	}
}
		
