using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class LittleGuyFSM : FSMComponent
    {
        Little_Guy guy;

        public LittleGuyFSM(ref Little_Guy guy)
        {
            states = new AIState[(int)LittleGuyStates.Size];
            states[(int)LittleGuyStates.Patrol] = new PatrolState(ref guy);
            states[(int)LittleGuyStates.Spin] = new SpinState(ref guy);
            states[(int)LittleGuyStates.Death] = new LittleGuyDeath(ref guy);
        }

        public override void Update(GameTime time)
        {
            currentState = states[currentState].PerformAction(time);
            guy.SetBehavior(currentState);
        }
    }
}
