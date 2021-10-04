using UnityEngine;

namespace Zun010.UnityBridge
{
    public class CollisionStay2dTracker : UnityBridgeTracker<Physics2dBridge>
    {
        private void OnCollisionStay2D(Collision2D other)
            => Bridge.CollisionStay2d(gameObject, other);
    }
}