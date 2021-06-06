namespace Zun010.UnityBridge
{
    internal class MouseEnterTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseEnter()
        {
            Bridge.MouseEnter(gameObject);
        }
    }
}