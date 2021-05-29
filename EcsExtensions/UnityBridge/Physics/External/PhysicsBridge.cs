using UnityEngine;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class PhysicsBridge : UnityBridge
    {
        internal void CollisionEnter(Collision other)
        {
            var collisionEnterComponent = new CollisionEnterComponent
            {
                Collider = other.collider,
                Impulse = other.impulse
            };

            World.NewEntityWith(collisionEnterComponent);
        }

        internal void CollisionExit(Collision other)
        {
            var collisionExitComponent = new CollisionExitComponent
            {
                Collider = other.collider
            };

            World.NewEntityWith(collisionExitComponent);
        }

        internal void CollisionStay(Collision other)
        {
            var collisionStayComponent = new CollisionStayComponent
            {
                Collider = other.collider
            };

            World.NewEntityWith(collisionStayComponent);
        }

        internal void TriggerEnter(Collider other)
        {
            var triggerEnterComponent = new TriggerEnterComponent
            {
                Collider = other
            };

            World.NewEntityWith(triggerEnterComponent);
        }

        internal void TriggerExit(Collider other)
        {
            var triggerExitComponent = new TriggerExitComponent
            {
                Collider = other
            };

            World.NewEntityWith(triggerExitComponent);
        }
        
        internal void TriggerStay(Collider other)
        {
            var triggerStayComponent = new TriggerStayComponent
            {
                Collider = other
            };

            World.NewEntityWith(triggerStayComponent);
        }
    }
}