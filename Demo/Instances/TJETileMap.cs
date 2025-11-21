using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class TJETileMap : TileMap
    {
        List<Pixel> pixels;
        private Texture2D texture2D;
        private Rectangle rectangle;
        private Func<Vector2> posFunc;

        public TJETileMap(Texture2D texture2D, 
            ref Func<Vector2> posFunc, 
            ref List<Func<Vector2>> displacementFuncs,
            ref List<TJEColor> colors,
            ref GameIndexer indexer,
            ref TextureManager textureManager,
            ref RectangleManager rectangleManager,
            float v)
            : base(ref posFunc, v)
        {
            this.texture2D = textureManager.Find(indexer.GetTextureIndex(TextureObjectType.Pixel));
            this.rectangle = rectangleManager.Find(indexer.GetRectangleIndex(GameObjectType.Pixel));
            this.posFunc = posFunc;

            pixels = new List<Pixel>();
            for (int i = 0; i < displacementFuncs.Count; i++)
            {
                pixels.Add(
                    new Pixel(displacementFuncs[i],
                        colors[i], 
                        ref textureManager.Find(indexer.GetTextureIndex(TextureObjectType.Pixel)),
                        ref rectangleManager.Find(indexer.GetRectangleIndex(GameObjectType.Pixel))));
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var pixel in pixels)
            {
                pixel.Draw(spriteBatch);
            }
        }
        public ref List<Pixel> GetTiles()
        {
            return ref pixels;
        }
    }
}