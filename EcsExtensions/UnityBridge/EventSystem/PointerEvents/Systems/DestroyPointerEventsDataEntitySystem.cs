using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class DestroyPointerEventsDataEntitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<PointerEnterComponent> _pointerEnterFilter = null;
        private readonly EcsFilter<PointerExitComponent> _pointerExitFilter = null;
        private readonly EcsFilter<PointerDownComponent> _pointerDownFilter = null;
        private readonly EcsFilter<PointerUpComponent> _pointerUpFilter = null;
        private readonly EcsFilter<PointerClickComponent> _pointerClickFilter = null;
        
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