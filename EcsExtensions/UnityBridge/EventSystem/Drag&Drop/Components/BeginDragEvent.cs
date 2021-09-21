using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct BeginDragEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}