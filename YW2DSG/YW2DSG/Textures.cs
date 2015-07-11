using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW2DSG
{
    class Textures
    {
        ContentManager content;

        List<Texture2D> textures = new List<Texture2D>();
        
        public void InitializeTextures(ContentManager contentmng)
        {
            content = contentmng;
            Initialize();
        }

        private void Initialize()
        {
            Texture2D Missing = content.Load<Texture2D>("Err001"); textures.Add(Missing); // ID: 0
            Texture2D Dirt = content.Load<Texture2D>("Dirt"); textures.Add(Dirt); //ID: 1
            Texture2D Rock = content.Load<Texture2D>("Rock"); textures.Add(Rock); //ID: 2

        }

        public Texture2D GetTextureFromID(int texturenum)
        {
            try
            {
                return textures[texturenum];
            }
            catch
            {
                return textures[0];
            }
        }


    }
}
