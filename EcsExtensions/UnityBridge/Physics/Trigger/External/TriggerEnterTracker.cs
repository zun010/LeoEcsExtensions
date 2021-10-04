using UnityEngine;

namespace Zun010.UnityBridge
{
    public class TriggerEnterTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnTriggerEnter(Collider other)
            => Bridge.TriggerEnter(other);
    }
}