using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4.Map
{
    public class Tile
    {
        
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int ZPos { get; set; }

        public int TextureXPos { get; set; }
        public int TextureYPos { get; set; }

        public string TextureName { get; set; }
        private Texture2D _texture;
        public Tile()
        {

        }

        public Tile(int xPos,int yPos,int zPos,int textureXPos, int textureYPos,string textureName)
        {
            XPos = xPos;
            YPos = yPos;
            ZPos = zPos;
            TextureXPos = textureXPos;
            TextureYPos = textureYPos;
            TextureName = textureName;
        }

        public  void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>(TextureName);
        }

        public void Update(double gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, new Rectangle(XPos * 16, YPos * 16,16,16), new Rectangle(TextureXPos * 16, TextureYPos * 16,16,16), Color.White);
        }
    }
}
