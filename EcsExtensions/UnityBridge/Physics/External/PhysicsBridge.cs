using UnityEngine;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class PhysicsBridge : UnityBridge
    {
        internal void CollisionEnter(Collision other)
        {
            var collisionEnterComponent = new CollisionEnterEvent
            {
                Collider = other.collider,
                Impulse = other.impulse
            };

            World.NewEntityWith(collisionEnterComponent);
        }

        internal void CollisionExit(Collision other)
        {
            var collisionExitComponent = new CollisionExitEvent
            {
                Collider = other.collider
            };

            World.NewEntityWith(collisionExitComponent);
        }

        internal void CollisionStay(Collision other)
        {
            var collisionStayComponent = new CollisionStayEvent
            {
                Collider = other.collider
            };

            World.NewEntityWith(collisionStayComponent);
        }

        internal void TriggerEnter(Collider other)
        {
            var triggerEnterComponent = new TriggerEnterEvent
            {
                Collider = other
            };

            World.NewEntityWith(triggerEnterComponent);
        }

        internal void TriggerExit(Collider other)
        {
            var triggerExitComponent = new TriggerExitEvent
            {
                Collider = other
            };

            World.NewEntityWith(triggerExitComponent);
        }
        
        internal void TriggerStay(Collider other)
        {
            var triggerStayComponent = new TriggerStayEvent
            {
                Collider = other
            };

            World.NewEntityWith(triggerStayComponent);
        }
    }
}