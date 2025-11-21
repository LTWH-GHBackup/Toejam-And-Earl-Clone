using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    internal class DownKey : KeyType
    {
        public DownKey(Keys key, ref BindList list) : base(key)
        {
            handler.AddKeyInput(ref input);
            handler.SetActiveState(0);

            list.AddEventHandler(key, ref handler);
        }
    }
}