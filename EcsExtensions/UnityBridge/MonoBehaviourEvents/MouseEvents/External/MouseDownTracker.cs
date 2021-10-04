namespace Zun010.UnityBridge
{
    public class MouseDownTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseDown()
        {
            Bridge.MouseDown(gameObject);
        }
    }
}