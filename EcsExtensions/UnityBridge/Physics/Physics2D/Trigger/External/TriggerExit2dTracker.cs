using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class TriggerExit2dTracker : UnityBridgeTracker<Physics2dBridge>
    {
        private void OnTriggerExit2D(Collider2D other)
            => Bridge.TriggerExit2d(other);
    }
}