using System;

namespace ToeJamAndEarlFirstBatch
{
    public class LittleGuyBehavior : GameplayComponent
    {
        BehaviorList behaviorLists;
        int _currentState;
        int Health = 100;

        public LittleGuyBehavior()
        {
            behaviorLists = new BehaviorList();
            Health = 100;
        }

        internal int GetHealth()
        {
            return Health;
        }

        internal void SetBehavior(int currentState)
        {
            _currentState = currentState;
        }
    }
}