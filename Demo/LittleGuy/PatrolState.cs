using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class PatrolState : AIState
    {
        Little_Guy _guy;
        public PatrolState(ref Little_Guy guy) 
        {
            _guy = guy;
        
        }
        public override int PerformAction(GameTime time)
        {
            LittleGuyStates res =  LittleGuyStates.Patrol;
            if (_guy.GetHealth() > 0)
            {
                if (_guy.SeesEnemy())
                {
                    res = LittleGuyStates.Spin;
                }
            }
            else 
            {
                res = LittleGuyStates.Death;
            }
            return (int)res;
        }

    }
}