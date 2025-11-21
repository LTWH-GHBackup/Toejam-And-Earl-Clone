using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ToeJamAndEarlFirstBatch.Core
{
    public class ComponentFactory
    {
        public static Component CreateNullComponent(Component.TypeID id)
        {
            Component component = null;
            switch (id)
            {
                case Component.TypeID.Audio:
                {
                        component = new NullAudio();
                        break;
                }
                case Component.TypeID.Gameplay:
                {
                        component = new NullGameComponent(Vector2.Zero);
                        break;
                }
                case Component.TypeID.Graphics:
                {
                        Vector2 deadzone = new Vector2(-10000, -10000);
                        Func<Vector2> ah = () => { return deadzone; };
                        component = new NullGraphicsComponent(ref ah, 0);
                        break;
                }
                case Component.TypeID.Physics:
                {
                        component = new NullPhysicsComponent();
                        break;
                }
                // Both shouldn't happen
                case Component.TypeID.SIZE:
                default:
                {
                    break;
                }
            }

            return component;
        }
    }
}
