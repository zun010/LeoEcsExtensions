using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class CollisionEnter2dTracker : UnityBridgeTracker<Physics2dBridge>
    {
        private void OnCollisionEnter2D(Collision2D other)
            => Bridge.CollisionEnter2d(gameObject, other);
    }
}