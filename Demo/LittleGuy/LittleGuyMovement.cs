using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class LittleGuyMovement : GameplayComponent
    {
        BehaviorList _list;

        public LittleGuyMovement(ref BehaviorList list)
        {
            _list = list;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _list.ActivateNextAction();
        }

    }
}
