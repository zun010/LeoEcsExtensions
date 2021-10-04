using UnityEngine;

namespace Zun010.UnityBridge
{
    public abstract class UnityBridgeTracker<T> : MonoBehaviour
        where T : UnityBridge
    {
        protected T Bridge;

        private void Start()
            => Bridge = UnityBridge.FindBridge<T>();
    }
}