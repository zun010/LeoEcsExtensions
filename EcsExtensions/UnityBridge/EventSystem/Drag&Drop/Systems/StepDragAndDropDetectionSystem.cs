using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class StepDragAndDropDetectionSystem : IEcsRunSystem
    {
        private readonly EcsFilter<BeginDragComponent> _beginDragFilter = null;
        private readonly EcsFilter<EndDragComponent> _endDragFilter = null;
        private readonly EcsFilter<DragComponent> _dragFilter = null;
        private readonly EcsFilter<DropComponent> _dropFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _beginDragFilter.ForAllEntity(_destroyEntityAction);
            _endDragFilter.ForAllEntity(_destroyEntityAction);
            _dragFilter.ForAllEntity(_destroyEntityAction);
            _dropFilter.ForAllEntity(_destroyEntityAction);
        }
    }
}