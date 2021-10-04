namespace Zun010.UnityBridge
{
    public class MouseExitTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseExit()
        {
            Bridge.MouseExit(gameObject);
        }
    }
}