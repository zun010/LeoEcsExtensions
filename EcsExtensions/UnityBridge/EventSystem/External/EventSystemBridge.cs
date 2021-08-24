using UnityEngine;
using UnityEngine.EventSystems;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class EventSystemBridge : UnityBridge
    {
        internal void PointerEnter(PointerEventData pointerEventData)
        {
            var pointerEnterComponent = new PointerEnterEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerEnterComponent);
        }

        internal void PointerExit(PointerEventData pointerEventData)
        {
            var pointerExitComponent = new PointerExitEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerExitComponent);
        }

        internal void PointerDown(PointerEventData pointerEventData)
        {
            var pointerDownComponent = new PointerDownEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerDownComponent);
        }

        internal void PointerUp(PointerEventData pointerEventData)
        {
            var pointerUpComponent = new PointerUpEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerUpComponent);
        }

        internal void PointerClick(PointerEventData pointerEventData)
        {
            var pointerClickComponent = new PointerClickEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerClickComponent);
        }
        
        internal void BeginDrag(PointerEventData pointerEventData)
        {
            var beginDragComponent = new BeginDragEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(beginDragComponent);
        }
        
        internal void EndDrag(PointerEventData pointerEventData)
        {
            var endDragComponent = new EndDragEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(endDragComponent);
        }
        
        internal void Drag(PointerEventData pointerEventData)
        {
            var dragComponent = new DragEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(dragComponent);
        }
        
        internal void Drop(PointerEventData pointerEventData)
        {
            var dropComponent = new DropEvent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(dropComponent);
        }
    }
}