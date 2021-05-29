using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class EcsCollisionTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnCollisionEnter(Collision other)
            => Bridge.CollisionEnter(other);

        private void OnCollisionExit(Collision other)
            => Bridge.CollisionExit(other);

        private void OnCollisionStay(Collision other)
            => Bridge.CollisionStay(other);
    }
}