using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct PointerEnterEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}