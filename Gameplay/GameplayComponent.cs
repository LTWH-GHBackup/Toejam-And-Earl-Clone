using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch
{
    public class GameplayComponent : Component
    {
        public Vector2 _position;

        public GameplayComponent() 
        {
            _position = Vector2.Zero;
        }
        public GameplayComponent(Vector2 position)
        {
            _position = position;
        }

        public void SetPosition (Vector2 _position)
        {
            this._position = _position;
        }
        public void SetPosition(int x, int y)
        {
            this._position = new Vector2(x, y);
        }

        public ref Vector2 GetPosition()
        {
            return ref this._position;
        }
    }
}
