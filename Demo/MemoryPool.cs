using System;

namespace ToeJamAndEarlFirstBatch
{
    public class MemoryPool
    {
        CollisionComponent[][] collisionComponents;

        public MemoryPool(int size = 4)
        {
            collisionComponents = new CollisionComponent[size][];
            for (int i = 0; i < size; i++)
            {
                collisionComponents[i] = new CollisionComponent[size];
            }

            for (int i = 0; i < size; i++)
            {
                collisionComponents[(int)CollisionComponent.Type.CollisionAABB][i] = new CollisionAABB();
                collisionComponents[(int)CollisionComponent.Type.CollisionBox][i] = new CollisionBox();
                collisionComponents[(int)CollisionComponent.Type.CollisionCapsule][i] = new CollisionCapsule();
                collisionComponents[(int)CollisionComponent.Type.CollisionSphere][i] = new CollisionSphere();
            }

        }

        public ref CollisionComponent GetCollisionObject(CollisionInstanceType objectType, ref GameIndexer indexer)
        {
            Tuple<int,int> index = indexer.GetCollisionIndex(objectType);
            return ref (collisionComponents[index.Item1][index.Item2]);
        }

    }
}