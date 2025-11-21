using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using ToeJamAndEarlFirstBatch;

namespace ToeJamAndEarlFirstBatch
{
    public class FSMComponent : AIComponent
    {
        protected AIState[] states;
        protected int currentState;

        public override void Update(GameTime time)
        {
            currentState = states[currentState].PerformAction(time);
        }

        public void SetState(int state)
        {
            currentState = state;
        }
    }
}
