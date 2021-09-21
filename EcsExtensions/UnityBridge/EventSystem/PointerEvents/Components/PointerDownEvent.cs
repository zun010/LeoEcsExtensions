using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct PointerDownEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}