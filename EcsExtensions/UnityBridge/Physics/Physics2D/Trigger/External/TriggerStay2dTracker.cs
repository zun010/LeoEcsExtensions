using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class TriggerStay2dTracker : UnityBridgeTracker<Physics2dBridge>
    {
        private void OnTriggerStay2D(Collider2D other)
            => Bridge.TriggerStay2d(other);
    }
}