using UnityEngine;

namespace Zun010.UnityBridge
{
    public struct RaycastRequestComponent
    {
        public Ray Ray;
        public float Distance;
        public LayerMask LayerMask;
    }
}