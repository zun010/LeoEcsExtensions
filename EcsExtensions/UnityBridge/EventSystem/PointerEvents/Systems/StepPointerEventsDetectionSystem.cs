using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class StepPointerEventsDetectionSystem : IEcsRunSystem
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
            _pointerEnterFilter.ForAllEntity(_destroyEntityAction);
            _pointerExitFilter.ForAllEntity(_destroyEntityAction);
            _pointerDownFilter.ForAllEntity(_destroyEntityAction);
            _pointerUpFilter.ForAllEntity(_destroyEntityAction);
            _pointerClickFilter.ForAllEntity(_destroyEntityAction);
        }
    }
}