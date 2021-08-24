using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class CollisionExitTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnCollisionExit(Collision other)
            => Bridge.CollisionExit(gameObject, other);
    }
}