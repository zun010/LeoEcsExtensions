using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public class PointerEnterTracker : UnityBridgeTracker<EventSystemBridge>, IPointerEnterHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
            => Bridge.PointerEnter(gameObject, eventData);
    }
}