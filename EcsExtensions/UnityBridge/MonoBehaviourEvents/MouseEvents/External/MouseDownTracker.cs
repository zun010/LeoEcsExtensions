namespace Zun010.UnityBridge
{
    internal class MouseDownTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseDown()
        {
            Bridge.MouseDown(gameObject);
        }
    }
}