using UnityEngine;

namespace Zun010.UnityBridge
{
    internal class TriggerStayTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnTriggerStay(Collider other)
            => Bridge.TriggerStay(other);
    }
}