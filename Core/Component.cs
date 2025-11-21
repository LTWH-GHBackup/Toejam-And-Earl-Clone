using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    // Dummy Class to be inherited
    public class Component
    {
        public enum TypeID : int
        {
            AI = 0,
            Audio = 1,
            Collision = 2,
            Gameplay = 3,
            Graphics = 4,
            Physics = 5,
            SIZE = 6,
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }
    }
}
