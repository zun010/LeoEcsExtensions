using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct PointerExitEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}