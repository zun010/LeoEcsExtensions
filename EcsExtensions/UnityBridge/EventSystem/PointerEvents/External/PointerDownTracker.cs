using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class PointerDownTracker : UnityBridgeTracker<EventSystemBridge>, IPointerDownHandler
    {
        public void OnPointerDown(PointerEventData eventData)
            => Bridge.PointerDown(eventData);
    }
}