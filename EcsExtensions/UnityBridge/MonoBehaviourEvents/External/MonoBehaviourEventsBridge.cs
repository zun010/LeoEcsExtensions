using UnityEngine;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class MonoBehaviourEventsBridge : UnityBridge
    {
        internal void MouseEnter(GameObject sender)
        {
            var mouseEnterComponent = new MouseEnterComponent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseEnterComponent);
        }
        
        internal void MouseExit(GameObject sender)
        {
            var mouseExitComponent = new MouseExitComponent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseExitComponent);
        }

        internal void MouseDown(GameObject sender)
        {
            var mouseDownComponent = new MouseDownComponent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseDownComponent);
        }

        internal void MouseUp(GameObject sender)
        {
            var mouseUpComponent = new MouseUpComponent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseUpComponent);
        }

        internal void MouseUpAsButton(GameObject sender)
        {
            var mouseUpAsButtonComponent = new MouseUpAsButtonComponent
            {
                Sender = sender
            };

            World.NewEntityWith(mouseUpAsButtonComponent);
        }
    }
}