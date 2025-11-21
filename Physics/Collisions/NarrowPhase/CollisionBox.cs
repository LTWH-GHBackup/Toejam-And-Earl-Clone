using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class CollisionBox : CollisionComponent
    {
        public Vector2 _center;
        float _halfSize;

        public CollisionBox(ref Texture2D texture, ref Rectangle rect,int scale, ref Vector2 pos, ref Vector2 center, float halfSize)
            : base(ref texture, ref rect, scale, pos)
        {
            _center = center;
            _halfSize = halfSize;
        }

        public CollisionBox()
        {
        }

        public override bool Visits(CollisionComponent obj1)
        {
            return obj1.CollidesWithCollisionBox(this);
        }

        public override bool CollidesWithCollisionBox(CollisionBox collisionBox)
        {

            return false;
        }

        public override bool CollidesWithCollisionAABB(CollisionAABB collisionAABB)
        {
            throw new System.NotImplementedException();
        }

        public override bool CollidesWithCollisionCapsule(CollisionCapsule collisionAABB)
        {
            throw new System.NotImplementedException();
        }

        public override bool CollidesWithCollisionSphere(CollisionSphere collisionAABB)
        {
            throw new System.NotImplementedException();
        }
    }
}