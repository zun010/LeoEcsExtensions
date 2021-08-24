using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class EcsCollisionTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnCollisionEnter(Collision other)
            => Bridge.CollisionEnter(gameObject, other);

        private void OnCollisionExit(Collision other)
            => Bridge.CollisionExit(gameObject, other);

        private void OnCollisionStay(Collision other)
            => Bridge.CollisionStay(gameObject, other);
    }
}