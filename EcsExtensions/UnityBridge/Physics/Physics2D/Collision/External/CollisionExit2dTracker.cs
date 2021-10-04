using UnityEngine;

namespace Zun010.UnityBridge
{
    public class CollisionExit2dTracker : UnityBridgeTracker<Physics2dBridge>
    {
        private void OnCollisionExit2D(Collision2D other)
            => Bridge.CollisionExit2d(gameObject, other);
    }
}