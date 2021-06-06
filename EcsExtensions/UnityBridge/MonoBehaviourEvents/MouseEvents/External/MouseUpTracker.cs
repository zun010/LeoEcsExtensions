namespace Zun010.UnityBridge
{
    internal class MouseUpTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseUp()
        {
            Bridge.MouseUp(gameObject);
        }
    }
}