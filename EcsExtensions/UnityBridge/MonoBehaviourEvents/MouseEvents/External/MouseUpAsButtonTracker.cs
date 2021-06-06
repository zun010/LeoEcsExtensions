namespace Zun010.UnityBridge
{
    internal class MouseUpAsButtonTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseUpAsButton()
        {
            Bridge.MouseUpAsButton(gameObject);
        }
    }
}