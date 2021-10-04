using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public class DragTracker : UnityBridgeTracker<EventSystemBridge>, IDragHandler
    {
        public void OnDrag(PointerEventData eventData) 
            => Bridge.Drag(gameObject, eventData);
    }
}