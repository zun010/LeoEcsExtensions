using UnityEngine;

namespace Zun010.UnityBridge
{
    public struct CollisionEnterEvent
    {
        public GameObject Sender;
        public Collider OtherCollider;
        public Vector3 Impulse;
    }
}