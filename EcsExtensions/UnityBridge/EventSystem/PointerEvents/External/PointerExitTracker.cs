using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public class PointerExitTracker : UnityBridgeTracker<EventSystemBridge>, IPointerExitHandler
    {
        public void OnPointerExit(PointerEventData eventData)
            => Bridge.PointerExit(gameObject, eventData);
    }
}