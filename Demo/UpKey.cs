using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    internal class UpKey : KeyType
    {
        public UpKey(Keys key, ref BindList list) : base(key)
        {
            handler.AddKeyInput(ref input);
            handler.SetActiveState(0);

            list.AddEventHandler(key, ref handler);
        }
    }
}