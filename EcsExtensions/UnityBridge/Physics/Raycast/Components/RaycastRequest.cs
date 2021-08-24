using UnityEngine;

namespace Zun010.UnityBridge
{
    public struct RaycastRequest
    {
        public Ray Ray;
        public float Distance;
        public LayerMask LayerMask;
    }
}