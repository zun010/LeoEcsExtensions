using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public class DropTracker : UnityBridgeTracker<EventSystemBridge>, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
            => Bridge.Drop(gameObject, eventData);
    }
}