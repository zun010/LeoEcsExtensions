using UnityEngine;

namespace Zun010.UnityBridge
{
    public struct CollisionEnter2dEvent
    {
        public GameObject Sender;
        public Collider2D OtherCollider;
        public Vector3 RelativeVelocity;
    }
}