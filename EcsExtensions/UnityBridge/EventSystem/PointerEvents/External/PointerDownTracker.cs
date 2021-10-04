using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public class PointerDownTracker : UnityBridgeTracker<EventSystemBridge>, IPointerDownHandler
    {
        public void OnPointerDown(PointerEventData eventData)
            => Bridge.PointerDown(gameObject, eventData);
    }
}