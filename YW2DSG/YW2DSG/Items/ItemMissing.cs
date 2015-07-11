using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace YW2DSG.Items
{
	class ItemMissing : GenericItem
	{
		public ItemMissing()
		{
			MaxStack = 128;
			ItemName = "Missing Err001";
			ItemID = 0;
			ItemTexture = TextureManager.GetTextureFromID(ItemID);
			ItemDesc = "''PHP 404 Tile Not Found''";
			TileName = Tiles.TileMissing();
		}
	}
}
		
