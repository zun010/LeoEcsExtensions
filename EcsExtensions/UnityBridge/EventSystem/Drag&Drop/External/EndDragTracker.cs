using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public class EndDragTracker : UnityBridgeTracker<EventSystemBridge>, IEndDragHandler
    {
        public void OnEndDrag(PointerEventData eventData)
            => Bridge.EndDrag(gameObject, eventData);
    }
}