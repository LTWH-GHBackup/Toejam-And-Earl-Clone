
using System;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    internal class ArrowControlled : GameplayComponent
    {

        bool shouldUseOrigin;

        Vector2 origin;
        Vector2 direction;

        public ArrowControlled(Vector2 origin, Vector2 direction)
        {
            this.origin = origin;
            this.direction = direction;
        }

        public Vector2 GetOrigin()
        {
            return origin;
        }

        public Vector2 GetDirection()
        {
            return direction;
        }

        public ref Vector2 GetActiveVector()
        {
            if (shouldUseOrigin)
            {
                return ref origin;
            }
            else
            {
                return ref direction;
            }
        }

        internal void SwapActiveVector()
        {
            shouldUseOrigin = !shouldUseOrigin;
        }
    }
}