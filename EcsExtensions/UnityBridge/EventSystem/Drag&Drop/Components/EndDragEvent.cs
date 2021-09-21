using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct EndDragEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}