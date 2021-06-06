namespace Zun010.UnityBridge
{
    internal class MouseExitTracker : UnityBridgeTracker<MonoBehaviourEventsBridge>
    {
        private void OnMouseExit()
        {
            Bridge.MouseExit(gameObject);
        }
    }
}