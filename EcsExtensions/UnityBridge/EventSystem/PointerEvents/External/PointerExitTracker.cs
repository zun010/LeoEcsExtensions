using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    internal class PointerExitTracker : UnityBridgeTracker<EventSystemBridge>, IPointerExitHandler
    {
        public void OnPointerExit(PointerEventData eventData)
            => Bridge.PointerExit(eventData);
    }
}