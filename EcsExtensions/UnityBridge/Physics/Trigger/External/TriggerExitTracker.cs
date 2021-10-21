using UnityEngine;

namespace Zun010.UnityBridge
{
    public class TriggerExitTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnTriggerExit(Collider other)
            => Bridge.TriggerExit(gameObject, other);
    }
}