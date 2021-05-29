using UnityEngine;

namespace Zun010.UnityBridge
{
    public struct RaycastAllRequestComponent
    {
        public Ray Ray;
        public float Distance;
        public LayerMask LayerMask;
        public RaycastHit[] RaycastHits;
    }
}