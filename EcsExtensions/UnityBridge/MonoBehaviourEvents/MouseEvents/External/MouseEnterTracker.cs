namespace Zun010.UnityBridge
{
    public class MouseEnterTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseEnter()
        {
            Bridge.MouseEnter(gameObject);
        }
    }
}