using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class ArrowGameComponent : GameplayComponent
    {
        Vector2 direction;
        public ArrowGameComponent() 
        {
        }

        public void SetDirection(Vector2 direction)
        {
            this.direction = direction;
        }
        public void SetDirection(int x, int y)
        {
            this.direction = new Vector2(x, y);
        }
    }
}
