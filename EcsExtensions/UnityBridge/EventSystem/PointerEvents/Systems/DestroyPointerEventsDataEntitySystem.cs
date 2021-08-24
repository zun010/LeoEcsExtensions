using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class DestroyPointerEventsDataEntitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<PointerEnterEvent> _pointerEnterFilter = null;
        private readonly EcsFilter<PointerExitEvent> _pointerExitFilter = null;
        private readonly EcsFilter<PointerDownEvent> _pointerDownFilter = null;
        private readonly EcsFilter<PointerUpEvent> _pointerUpFilter = null;
        private readonly EcsFilter<PointerClickEvent> _pointerClickFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _pointerEnterFilter.ForEachEntity(_destroyEntityAction);
            _pointerExitFilter.ForEachEntity(_destroyEntityAction);
            _pointerDownFilter.ForEachEntity(_destroyEntityAction);
            _pointerUpFilter.ForEachEntity(_destroyEntityAction);
            _pointerClickFilter.ForEachEntity(_destroyEntityAction);
        }
    }
}