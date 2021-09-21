using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class PointerUpTracker : UnityBridgeTracker<EventSystemBridge>, IPointerUpHandler
    {
        public void OnPointerUp(PointerEventData eventData)
            => Bridge.PointerUp(gameObject, eventData);
    }
}