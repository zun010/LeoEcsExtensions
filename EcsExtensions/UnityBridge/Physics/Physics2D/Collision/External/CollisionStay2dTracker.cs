using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class CollisionStay2dTracker : UnityBridgeTracker<Physics2dBridge>
    {
        private void OnCollisionStay2D(Collision2D other)
            => Bridge.CollisionStay2d(gameObject, other);
    }
}