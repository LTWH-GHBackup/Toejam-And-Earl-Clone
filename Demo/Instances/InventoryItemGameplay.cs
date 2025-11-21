using System;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    internal class InventoryItemGameplay : GameplayComponent
    {
        private Func<Vector2> posFunc;

        public InventoryItemGameplay(ref Func<Vector2> posFunc)
        {
            this.posFunc = posFunc;
        }
    }
}