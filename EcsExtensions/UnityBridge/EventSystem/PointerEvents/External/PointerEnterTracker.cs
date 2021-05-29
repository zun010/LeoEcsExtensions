using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class PointerEnterTracker : UnityBridgeTracker<EventSystemBridge>, IPointerEnterHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
            => Bridge.PointerEnter(eventData);
    }
}