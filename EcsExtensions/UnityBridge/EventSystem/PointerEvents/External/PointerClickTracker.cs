using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public class PointerClickTracker : UnityBridgeTracker<EventSystemBridge>, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
            => Bridge.PointerClick(gameObject, eventData);
    }
}