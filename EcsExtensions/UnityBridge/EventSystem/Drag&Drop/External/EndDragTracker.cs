using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class EndDragTracker : UnityBridgeTracker<EventSystemBridge>, IEndDragHandler
    {
        public void OnEndDrag(PointerEventData eventData)
            => Bridge.EndDrag(eventData);
    }
}