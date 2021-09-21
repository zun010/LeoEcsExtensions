using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct PointerClickEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}