using UnityEngine;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class Physics2dBridge : UnityBridge
    {
        internal void CollisionEnter2d(GameObject sender, Collision2D other)
        {
            var collisionEnterComponent = new CollisionEnter2dEvent
            {
                Sender = sender,
                OtherCollider = other.collider,
                RelativeVelocity = other.relativeVelocity
            };

            World.NewEntityWith(collisionEnterComponent);
        }

        internal void CollisionExit2d(GameObject sender, Collision2D other)
        {
            var collisionExitComponent = new CollisionExit2dEvent
            {
                Sender = sender,
                OtherCollider = other.collider
            };

            World.NewEntityWith(collisionExitComponent);
        }

        internal void CollisionStay2d(GameObject sender, Collision2D other)
        {
            var collisionStayComponent = new CollisionStay2dEvent
            {
                Sender = sender,
                OtherCollider = other.collider
            };

            World.NewEntityWith(collisionStayComponent);
        }

        internal void TriggerEnter2d(Collider2D other)
        {
            var triggerEnterComponent = new TriggerEnter2dEvent
            {
                OtherCollider = other
            };

            World.NewEntityWith(triggerEnterComponent);
        }

        internal void TriggerExit2d(Collider2D other)
        {
            var triggerExitComponent = new TriggerExit2dEvent
            {
                OtherCollider = other
            };

            World.NewEntityWith(triggerExitComponent);
        }
        
        internal void TriggerStay2d(Collider2D other)
        {
            var triggerStayComponent = new TriggerStay2dEvent
            {
                OtherCollider = other
            };

            World.NewEntityWith(triggerStayComponent);
        }
    }
}