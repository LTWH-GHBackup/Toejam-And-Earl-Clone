using Microsoft.Xna.Framework;
using System;

namespace ToeJamAndEarlFirstBatch
{
    public class InventoryItem : GameObject
    {
        public InventoryItem(ref GameIndexer indexer, 
            ref TextureManager textureManager, 
            ref RectangleManager rectangleManager, 
            ref Func<Vector2> posFunc,
            float invScale) : 
            base(new ComponentArrayMap(
                (int)Component.TypeID.SIZE, 
                [Component.TypeID.AI,
                Component.TypeID.Audio,
                Component.TypeID.Collision,
                Component.TypeID.Gameplay,
                Component.TypeID.Graphics,
                Component.TypeID.Physics]))
        {
            Component comp = null;

            comp = new InventoryItemGameplay(ref posFunc);
            _map.AddComponent(Component.TypeID.Gameplay, ref comp);

            GameplayComponent gaComp = (GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay);

            comp = new NullAI();
            _map.AddComponent(Component.TypeID.AI, ref comp);

            comp = new InventoryItemGraphics(ref textureManager.Find(indexer.GetTextureIndex(TextureObjectType.Null)), 
                ref rectangleManager.Find(indexer.GetRectangleIndex(GameObjectType.Inventory)),
                ref posFunc,
                invScale);
            _map.AddComponent(Component.TypeID.Graphics, ref comp);

        }

    }
}