using Game4.Map;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Threading.Tasks;


namespace Game4.Manager
{
    class ManagerMap
    {
        private List<Tile> _tiles;
        private string _mapName;

        public ManagerMap(string mapName)
        {
            _tiles = new List<Tile>();
            _mapName = mapName;
        }

        public void LoadContent(ContentManager content)
        {
            var tiles = new List<Tile>();
            
            XMLSerialization.LoadXml(out tiles, string.Format("Content\\untitled.tmx", _mapName));
            if (tiles != null)
            {
                _tiles = tiles;
                _tiles.Sort((n, i) =>
                {
                    return n.ZPos > i.ZPos ? 1 : 0;
                });
                foreach (var tile in _tiles) {
                    tile.LoadContent(content);
                }
            }
        }

        public void Update(double gameTime)
        {
            foreach (var tile in _tiles)
            {
                tile.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(var tile in _tiles)
            {
                tile.Draw(spriteBatch);
            }
        }

       
    }
}
