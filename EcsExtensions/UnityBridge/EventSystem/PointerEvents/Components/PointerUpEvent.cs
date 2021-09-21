using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct PointerUpEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}