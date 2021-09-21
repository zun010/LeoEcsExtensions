using UnityEngine;
using UnityEngine.EventSystems;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class EventSystemBridge : UnityBridge
    {
        internal void PointerEnter(GameObject sender, PointerEventData pointerEventData)
        {
            var pointerEnterComponent = new PointerEnterEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerEnterComponent);
        }

        internal void PointerExit(GameObject sender, PointerEventData pointerEventData)
        {
            var pointerExitComponent = new PointerExitEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerExitComponent);
        }

        internal void PointerDown(GameObject sender, PointerEventData pointerEventData)
        {
            var pointerDownComponent = new PointerDownEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerDownComponent);
        }

        internal void PointerUp(GameObject sender, PointerEventData pointerEventData)
        {
            var pointerUpComponent = new PointerUpEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerUpComponent);
        }

        internal void PointerClick(GameObject sender, PointerEventData pointerEventData)
        {
            var pointerClickComponent = new PointerClickEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerClickComponent);
        }
        
        internal void BeginDrag(GameObject sender, PointerEventData pointerEventData)
        {
            var beginDragComponent = new BeginDragEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(beginDragComponent);
        }
        
        internal void EndDrag(GameObject sender, PointerEventData pointerEventData)
        {
            var endDragComponent = new EndDragEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(endDragComponent);
        }
        
        internal void Drag(GameObject sender, PointerEventData pointerEventData)
        {
            var dragComponent = new DragEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(dragComponent);
        }
        
        internal void Drop(GameObject sender, PointerEventData pointerEventData)
        {
            var dropComponent = new DropEvent
            {
                Sender = sender,
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(dropComponent);
        }
    }
}