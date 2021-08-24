using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class CollisionStayTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnCollisionStay(Collision other)
            => Bridge.CollisionStay(gameObject, other);
    }
}