using UnityEngine;
using UnityEngine.EventSystems;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    internal class EventSystemBridge : UnityBridge
    {
        internal void PointerEnter(PointerEventData pointerEventData)
        {
            var pointerEnterComponent = new PointerEnterComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerEnterComponent);
        }

        internal void PointerExit(PointerEventData pointerEventData)
        {
            var pointerExitComponent = new PointerExitComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerExitComponent);
        }

        internal void PointerDown(PointerEventData pointerEventData)
        {
            var pointerDownComponent = new PointerDownComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerDownComponent);
        }

        internal void PointerUp(PointerEventData pointerEventData)
        {
            var pointerUpComponent = new PointerUpComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerUpComponent);
        }

        internal void PointerClick(PointerEventData pointerEventData)
        {
            var pointerClickComponent = new PointerClickComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(pointerClickComponent);
        }
        
        internal void BeginDrag(PointerEventData pointerEventData)
        {
            var beginDragComponent = new BeginDragComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(beginDragComponent);
        }
        
        internal void EndDrag(PointerEventData pointerEventData)
        {
            var endDragComponent = new EndDragComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(endDragComponent);
        }
        
        internal void Drag(PointerEventData pointerEventData)
        {
            var dragComponent = new DragComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(dragComponent);
        }
        
        internal void Drop(PointerEventData pointerEventData)
        {
            var dropComponent = new DropComponent
            {
                PointerEventData = pointerEventData
            };

            World.NewEntityWith(dropComponent);
        }
    }
}