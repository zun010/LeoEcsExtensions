using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class TriggerExitTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnTriggerExit(Collider other)
            => Bridge.TriggerExit(other);
    }
}