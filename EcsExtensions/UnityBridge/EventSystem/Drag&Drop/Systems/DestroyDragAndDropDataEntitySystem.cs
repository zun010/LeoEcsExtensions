using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class DestroyDragAndDropDataEntitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<BeginDragEvent> _beginDragFilter = null;
        private readonly EcsFilter<EndDragEvent> _endDragFilter = null;
        private readonly EcsFilter<DragEvent> _dragFilter = null;
        private readonly EcsFilter<DropEvent> _dropFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _beginDragFilter.ForEachEntity(_destroyEntityAction);
            _endDragFilter.ForEachEntity(_destroyEntityAction);
            _dragFilter.ForEachEntity(_destroyEntityAction);
            _dropFilter.ForEachEntity(_destroyEntityAction);
        }
    }
}