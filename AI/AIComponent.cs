using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class AIComponent : Component
    {

        public virtual void Update(GameTime gameTime, ref AIComponent comp)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }
    }
}
