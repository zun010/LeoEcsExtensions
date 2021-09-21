using UnityEngine;
using UnityEngine.EventSystems;

namespace Zun010.UnityBridge
{
    public struct DropEvent
    {
        public GameObject Sender;
        public PointerEventData PointerEventData;
    }
}