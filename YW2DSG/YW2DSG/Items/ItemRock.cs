using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace YW2DSG.Items
{
	class ItemRock : GenericItem
	{
		public ItemRock()
		{
			MaxStack = 128;
			ItemName = "Rock Tile";
			ItemID = 2;
			ItemTexture = TextureManager.GetTextureFromID(ItemID);
			ItemDesc = "''It's harden than you think. It's a rock.''";
			TileName = Tiles.TileRock();
		}
	}
}
		
