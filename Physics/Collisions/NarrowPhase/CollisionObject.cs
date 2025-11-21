using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public abstract class CollisionComponent : Component
    {
        GraphicsComponent visualComponent;

        public CollisionComponent(ref Texture2D texture, ref Rectangle rect, int scale, Vector2 pos)
        {
            Func<Vector2> ah = () => { return pos; };
            visualComponent = new BasicGraphicsComponent(new Sprite(texture, rect), ref ah, scale);
        }

        public CollisionComponent()
        {

        }

        public enum Type
        {
            CollisionBox,
            CollisionAABB,
            CollisionCapsule,
            CollisionSphere,
        }

        public abstract bool Visits(CollisionComponent obj1);
        public abstract bool CollidesWithCollisionBox(CollisionBox collisionBox);
        public abstract bool CollidesWithCollisionAABB(CollisionAABB collisionAABB);
        public abstract bool CollidesWithCollisionCapsule(CollisionCapsule collisionCapsule);
        public abstract bool CollidesWithCollisionSphere(CollisionSphere collisionSphere);

        public void Draw(SpriteBatch spriteBatch, Vector2 pos)
        {
            visualComponent.Draw(spriteBatch);
        }
    }
}
