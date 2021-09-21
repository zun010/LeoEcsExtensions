using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class TriggerEnter2dTracker : UnityBridgeTracker<Physics2dBridge>
    {
        private void OnTriggerEnter2D(Collider2D other)
            => Bridge.TriggerEnter2d(other);
    }
}