using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class Level0 : Level
    {
        public Level0(ref GameIndexer indexer,
            ref TextureManager textureManager,
            ref RectangleManager rectangleManager, 
            Vector2 position)
            : base()
        {
            Component comp = null;

            comp = new NullGameComponent(position);
            _map.AddComponent(Component.TypeID.Gameplay, ref comp);

            GameplayComponent gaComp = (GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay);
            Func<Vector2> posFunc = () => gaComp.GetPosition();

            comp = new NullAI();
            _map.AddComponent(Component.TypeID.AI, ref comp);

            List<Func<Vector2>> displacementPositions = new List<Func<Vector2>> {};
            for(int i = 0; i < 3; ++i)
            {

                Func<Vector2> displacementFunc = () => { return gaComp.GetPosition() + new Vector2(50 * i, 50 * i); };
                displacementPositions.Add(displacementFunc);
            }

            List<TJEColor> colors = new List<TJEColor> { TJEColors.landbackground, 
                TJEColors.landbackground, 
                TJEColors.landbackground };
            Vector2 currPos = gaComp.GetPosition();
            
            comp = new TJETileMap(
                textureManager.Find(indexer.GetTextureIndex(TextureObjectType.Pixel)),
                ref posFunc,
                ref displacementPositions,
                ref colors,
                ref indexer,
                ref textureManager,
                ref rectangleManager,
                1.0f
                );
            _map.AddComponent(Component.TypeID.Graphics, ref comp);
        }
    }
}