using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework.Input;

namespace ToeJamAndEarlFirstBatch
{
    class RightKey : KeyType
    {
        public RightKey(Keys key, ref BindList list)
            : base(key)
            {
                SubscriberList subscriberList = new SubscriberList();
                input.AddInputSubscriber(KeyState.UNPRESSED, ref subscriberList);
                
                subscriberList = new SubscriberList();
                input.AddInputSubscriber(KeyState.JUSTPRESSED, ref subscriberList);
                
                subscriberList = new SubscriberList();
                input.AddInputSubscriber(KeyState.JUSTRELEASED, ref subscriberList);
                
                subscriberList = new SubscriberList();
                input.AddInputSubscriber(KeyState.HELD, ref subscriberList);
                
                handler.AddKeyInput(ref input);
                handler.SetActiveState(0);
                list.AddEventHandler(key, ref handler);
            }
    }
}