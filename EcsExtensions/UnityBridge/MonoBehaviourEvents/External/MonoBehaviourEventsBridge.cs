using UnityEngine;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class MonoBehaviourEventsBridge : UnityBridge
    {
        internal void MouseEnter(GameObject sender)
        {
            var mouseEnterComponent = new MouseEnterEvent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseEnterComponent);
        }
        
        internal void MouseExit(GameObject sender)
        {
            var mouseExitComponent = new MouseExitEvent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseExitComponent);
        }

        internal void MouseDown(GameObject sender)
        {
            var mouseDownComponent = new MouseDownEvent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseDownComponent);
        }

        internal void MouseUp(GameObject sender)
        {
            var mouseUpComponent = new MouseUpEvent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseUpComponent);
        }

        internal void MouseUpAsButton(GameObject sender)
        {
            var mouseUpAsButtonComponent = new MouseUpAsButtonEvent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseUpAsButtonComponent);
        }
    }
}