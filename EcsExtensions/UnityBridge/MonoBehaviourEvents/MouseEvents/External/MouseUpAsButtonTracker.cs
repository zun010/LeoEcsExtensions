namespace Zun010.UnityBridge
{
    public class MouseUpAsButtonTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseUpAsButton()
        {
            Bridge.MouseUpAsButton(gameObject);
        }
    }
}