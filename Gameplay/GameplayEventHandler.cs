using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class GameplayEventHandler
    {
        public enum State : int
        {
            gameplay = 0,
            paused = 1,
            developer = 2,
        }

        public GameplayEventHandler()
        {
        }

        public void Update(GameTime gametime)
        {
            states[(int)_state].Update(gametime);
        }

        public void Draw()
        {
            states[(int)_state].Draw();
        }

        public void SetCurrentState(int state)
        {
            _state = (State)state;
        }

        public void SetCurrentState(State state)
        {
            _state = state;
        }

        public void AddGameObject(ref GameObject obj)
        {
            states[0].AddGameObject(ref obj);
            ((PauseState)(states[1])).AddDrawableObject(ref obj);
            ((DeveloperState)states[2]).AddReferableObject(ref obj);
        }

        State _state;
        GamePlayState[] states = new GamePlayState[3];
    }
}
