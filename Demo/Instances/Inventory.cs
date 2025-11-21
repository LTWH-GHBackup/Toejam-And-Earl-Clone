using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static ToeJamAndEarlFirstBatch.Component;

namespace ToeJamAndEarlFirstBatch
{
    internal class Inventory : GameObject
    {
        private GameIndexer indexer;
        private Texture2D texture2D;
        private RectangleManager rectangleManager;
        private bool v;
        InventoryItem[] items = new InventoryItem[20];

        public Inventory(ref GameIndexer indexer, ref TextureManager textureManager, 
            ref RectangleManager rectangleManager, Vector2 position, int ScreenWidth, int ScreenHeight)
            :base(new ComponentArrayMap((int) Component.TypeID.SIZE, [Component.TypeID.AI,
              Component.TypeID.Audio,
              Component.TypeID.Collision,
              Component.TypeID.Gameplay,
              Component.TypeID.Graphics,
              Component.TypeID.Physics]))
        {
            Component comp = null;

            comp = new InventoryGameplay(position, ref items);
            _map.AddComponent(Component.TypeID.Gameplay, ref comp);

            GameplayComponent gaComp = (GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay);
            Func<Vector2> posFunc = () => gaComp.GetPosition();

            Vector2 currPos = gaComp.GetPosition();

            float invScale = 1.0f;
            for (int i = 0; i < 20; i++)
            {
                Func<Vector2> displacementFunc = () => { 
                    Vector2 pos = new Vector2();
                    pos.X = i % 2 == 0 ? 50 : 300;

                    float multiplier = i / 2;
                    pos.Y = (multiplier * 50) + currPos.Y;
                    return gaComp.GetPosition() + pos;
                };
                items[i] = new InventoryItem(ref indexer, 
                    ref textureManager, 
                    ref rectangleManager, 
                    ref displacementFunc, 
                    invScale);
            }

            InventoryGameplay invGame = gaComp as InventoryGameplay;
            invGame.SetInventorySpace(ref items);

            comp = new NullAI();
            _map.AddComponent(Component.TypeID.AI, ref comp);

            comp = new InventoryGraphics(textureManager.Find(indexer.GetTextureIndex(TextureObjectType.Inventory)),
                rectangleManager.Find(indexer.GetRectangleIndex(GameObjectType.Inventory)), 
                ref posFunc);
            _map.AddComponent(Component.TypeID.Graphics, ref comp);
        }

        internal ref InventoryItem[] GetInventorySpace()
        {
            return ref items;
        }

        internal void ToggleDisplay()
        {
            ((InventoryGameplay)this.GetComponent((int)Component.TypeID.Gameplay)).SwapDisplay();
        }
    }
}