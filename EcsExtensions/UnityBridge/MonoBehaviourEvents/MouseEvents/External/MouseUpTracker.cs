namespace Zun010.UnityBridge
{
    public class MouseUpTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseUp()
        {
            Bridge.MouseUp(gameObject);
        }
    }
}