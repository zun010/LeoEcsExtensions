using UnityEngine;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public sealed class PhysicsBridge : UnityBridge
    {
        internal void CollisionEnter(GameObject sender, Collision other)
        {
            var collisionEnterComponent = new CollisionEnterEvent
            {
                Sender = sender,
                OtherCollider = other.collider,
                Impulse = other.impulse
            };

            World.NewEntityWith(collisionEnterComponent);
        }

        internal void CollisionExit(GameObject sender, Collision other)
        {
            var collisionExitComponent = new CollisionExitEvent
            {
                Sender = sender,
                OtherCollider = other.collider
            };

            World.NewEntityWith(collisionExitComponent);
        }

        internal void CollisionStay(GameObject sender, Collision other)
        {
            var collisionStayComponent = new CollisionStayEvent
            {
                Sender = sender,
                OtherCollider = other.collider
            };

            World.NewEntityWith(collisionStayComponent);
        }

        internal void TriggerEnter(GameObject sender, Collider other)
        {
            var triggerEnterComponent = new TriggerEnterEvent
            {
                Sender = sender,
                OtherCollider = other
            };

            World.NewEntityWith(triggerEnterComponent);
        }

        internal void TriggerExit(GameObject sender, Collider other)
        {
            var triggerExitComponent = new TriggerExitEvent
            {
                Sender = sender,
                OtherCollider = other
            };

            World.NewEntityWith(triggerExitComponent);
        }
        
        internal void TriggerStay(GameObject sender, Collider other)
        {
            var triggerStayComponent = new TriggerStayEvent
            {
                Sender = sender,
                OtherCollider = other
            };

            World.NewEntityWith(triggerStayComponent);
        }
    }
}