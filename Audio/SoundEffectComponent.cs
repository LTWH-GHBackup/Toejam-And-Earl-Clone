using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace ToeJamAndEarlFirstBatch.Audio
{
    public class SoundEffectComponent : AudioComponent
    {
        SoundEffect effect;
        SoundEffectInstance instance;

        public override void Update(GameTime time)
        {
            base.Update(time);

            if(instance.State == SoundState.Stopped)
            {
                // Do something
            }
        }
    }
}
