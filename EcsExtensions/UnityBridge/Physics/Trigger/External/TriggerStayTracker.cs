using UnityEngine;

namespace Zun010.UnityBridge
{
    public class TriggerStayTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnTriggerStay(Collider other)
            => Bridge.TriggerStay(gameObject, other);
    }
}