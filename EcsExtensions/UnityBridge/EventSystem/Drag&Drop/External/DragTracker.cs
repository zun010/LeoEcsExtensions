using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class DragTracker : UnityBridgeTracker<EventSystemBridge>, IDragHandler
    {
        public void OnDrag(PointerEventData eventData) 
            => Bridge.Drag(gameObject, eventData);
    }
}