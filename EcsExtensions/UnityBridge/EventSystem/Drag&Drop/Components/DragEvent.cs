using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct DragEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}