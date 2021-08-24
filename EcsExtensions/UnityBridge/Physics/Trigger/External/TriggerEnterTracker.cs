using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class TriggerEnterTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnTriggerEnter(Collider other)
            => Bridge.TriggerEnter(other);
    }
}