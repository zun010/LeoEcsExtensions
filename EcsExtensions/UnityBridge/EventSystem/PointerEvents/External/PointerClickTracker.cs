using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class PointerClickTracker : UnityBridgeTracker<EventSystemBridge>, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
            => Bridge.PointerClick(gameObject, eventData);
    }
}