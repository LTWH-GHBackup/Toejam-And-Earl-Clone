
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ToeJamAndEarlFirstBatch.Core;

namespace ToeJamAndEarlFirstBatch
{
    public class Arrow : GameObject
    {
        public enum Direction
        {
            LEFT,
            RIGHT,
            UP,
            DOWN,
        }

        public Arrow(
            ref GameIndexer indexer,
            ref TextureManager texture,
            ref RectangleManager rectangleManager,
            Vector2 origin,
            Vector2 direction
            )
            : base(
                  new ComponentArrayMap((int)Component.TypeID.SIZE, [Component.TypeID.AI,
                             Component.TypeID.Audio,
                             Component.TypeID.Collision,
                             Component.TypeID.Gameplay,
                             Component.TypeID.Graphics,
                             Component.TypeID.Physics])
                  )
        {
            Component comp = null;
            List<int> list = indexer.getRectangleInputPattern(GameObjectType.Arrow);

            comp = new NullAI();
            _map.AddComponent(Component.TypeID.AI, ref comp);

            comp = new NullAudio();
            _map.AddComponent(Component.TypeID.Audio, ref comp);

            comp = new NullCollision();
            _map.AddComponent(Component.TypeID.Collision, ref comp);

            comp = new ArrowControlled(origin, direction);
            _map.AddComponent(Component.TypeID.Gameplay, ref comp);

            ArrowControlled gameplay = comp as ArrowControlled;
            Func<Vector2> forigin = () => { return gameplay.GetOrigin(); };
            Func<Vector2> fdirection = () => { return gameplay.GetDirection(); };

            comp = new FreeAngleGraphicsComponent(texture.Find(indexer.GetTextureIndex(TextureObjectType.Arrow))
                , rectangleManager.Find(indexer.GetRectangleIndex(GameObjectType.Arrow))
                ,ref forigin, ref fdirection);    
            _map.AddComponent(Component.TypeID.Graphics, ref comp);
        }

        internal void SetDirection(int v1, int v2)
        {
            ((FreeAngleGraphicsComponent)this._map.GetComponentOf(Component.TypeID.Graphics)).SetDirection(v1, v2);
        }

        internal void SetPosition(int v1, int v2)
        {
            ((FreeAngleGraphicsComponent)this._map.GetComponentOf(Component.TypeID.Graphics)).SetPosition(v1, v2);
        }

        public void SwapMoveLocation()
        {
            ((ArrowControlled)this.GetComponent((int)Component.TypeID.Gameplay)).SwapActiveVector();
        }

        internal void Move(Direction direction)
        {
            ref Vector2 vec = ref ((ArrowControlled)this.GetComponent((int)Component.TypeID.Gameplay)).GetActiveVector();
            ///GameplayComponent gameplay = (GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay);
            switch (direction)
            {
                case Arrow.Direction.LEFT:
                    //gameplay.position += new Vector2(-1, 0);
                    vec += new Vector2(-1, 0);
                    break;
                case Arrow.Direction.RIGHT:
                    //gameplay.position += new Vector2(1, 0);
                    vec += new Vector2(1, 0);
                    break;
                case Arrow.Direction.UP:
                    //gameplay.position += new Vector2(0, -1);
                    vec += new Vector2(0, -1);
                    break;
                case Arrow.Direction.DOWN:
                    //gameplay.position += new Vector2(0, 1);
                    vec += new Vector2(0, 1);
                    break;
                default: 
                    break;
            }
        }
    }
}
