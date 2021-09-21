using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class BeginDragTracker : UnityBridgeTracker<EventSystemBridge>, IBeginDragHandler
    {
        public void OnBeginDrag(PointerEventData eventData)
            => Bridge.BeginDrag(gameObject, eventData);
    }
}