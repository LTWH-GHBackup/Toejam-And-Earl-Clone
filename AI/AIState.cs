using Microsoft.Xna.Framework;
namespace ToeJamAndEarlFirstBatch
{
    public class AIState
    {
        public virtual int PerformAction(GameTime time)
        {
            return 0;
        }

        public virtual void NotifyTransitioner()
        {
            
        }
    }
}