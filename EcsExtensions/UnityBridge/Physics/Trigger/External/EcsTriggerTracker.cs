using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class EcsTriggerTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnTriggerEnter(Collider other)
            => Bridge.TriggerEnter(other);

        private void OnTriggerExit(Collider other)
            => Bridge.TriggerExit(other);

        private void OnTriggerStay(Collider other)
            => Bridge.TriggerStay(other);
    }
}