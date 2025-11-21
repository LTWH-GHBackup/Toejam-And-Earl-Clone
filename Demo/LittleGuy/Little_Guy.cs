using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class Little_Guy : GameObject
    {
        public Little_Guy( ref GameIndexer indexer,
            ref Texture2D texture,
            ref RectangleManager rectangleManager,
            bool playerControlled
            )
            : base(new ComponentArrayMap((int)Component.TypeID.SIZE,[Component.TypeID.AI,
                             Component.TypeID.Audio,
                             Component.TypeID.Collision,
                             Component.TypeID.Gameplay,
                             Component.TypeID.Graphics,
                             Component.TypeID.Physics]))
        {
            Component comp = null;

            List<int> list = new List<int>();
            for (int i = 0; i < 32; ++i)
            {
                list.Add(i);
            }
            if (playerControlled)
            {
                comp = new LittleGuyControlled();
                _map.AddComponent(Component.TypeID.Gameplay, ref comp);
                comp = new LittleGuyPlayer();

            }
            else
            {
                comp = new LittleGuyBehavior();
                _map.AddComponent(Component.TypeID.Gameplay, ref comp);

                Little_Guy guy = this;
                comp = new LittleGuyFSM(ref guy);
            }
            _map.AddComponent(Component.TypeID.AI, ref comp);

            GameplayComponent gaComp = (GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay);

            Func<Vector2> res = () => gaComp.GetPosition();
            comp = new LittleGuyAnimation(ref texture, list,
            ref rectangleManager, 0, ref res,  4.0f);
            _map.AddComponent(Component.TypeID.Graphics, ref comp);

        }

        public void SetPosition(Vector2 position)
        {
            ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))._position = position;
        }

        public Vector2 GetPosition()
        {
            return ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))._position;
        }

        private void RotateCW(float degrees)
        {
            ((LittleGuyAnimation)this.GetComponent((int)Component.TypeID.Graphics)).Rotate(degrees);
        }

        public void Move(LittleGuyDirection LittleGuyDirection)
        {
            switch (LittleGuyDirection)
            {
                case LittleGuyDirection.RIGHT:

                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position += new Vector2(1,0);
                    break;
                case LittleGuyDirection.RIGHT_CW_45:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position += new Vector2(1, 0);
                    break;
                case LittleGuyDirection.FRONT:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position += new Vector2(0, 1);
                    break;
                case LittleGuyDirection.FRONT_CW_45:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position += new Vector2(0, 1);
                    break;
                case LittleGuyDirection.BACK:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position -= new Vector2(0, 1);
                    break;
                case LittleGuyDirection.BACK_CW_45:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position += new Vector2(0, 1);
                    break;
                case LittleGuyDirection.LEFT:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position -= new Vector2(1, 0);
                    break;
                case LittleGuyDirection.LEFT_CW_45:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        ._position += new Vector2(0, 1);
                    break;
                default:
                    break;
            }
        }

        public float GetScale()
        {
            return ((GraphicsComponent)this.GetComponent((int)Component.TypeID.Graphics)).GetScale();
        }

        internal int GetHealth()
        {
            return ((LittleGuyBehavior)this.GetComponent((int)Component.TypeID.Gameplay)).GetHealth();
        }

        internal bool SeesEnemy()
        {
            throw new NotImplementedException();
        }

        public void SetBehavior(int currentState)
        {
            ((LittleGuyBehavior)this.GetComponent((int)Component.TypeID.Gameplay)).SetBehavior(currentState);
        }
    }
}
