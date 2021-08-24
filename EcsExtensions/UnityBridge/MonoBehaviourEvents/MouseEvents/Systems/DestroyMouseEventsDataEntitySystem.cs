using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class DestroyMouseEventsDataEntitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<MouseEnterEvent> _mouseEnterFilter = null;
        private readonly EcsFilter<MouseExitEvent> _mouseExitFilter = null;
        private readonly EcsFilter<MouseDownEvent> _mouseDownFilter = null;
        private readonly EcsFilter<MouseUpEvent> _mouseUpFilter = null;
        private readonly EcsFilter<MouseUpAsButtonEvent> _mouseUpAsButtonFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _mouseEnterFilter.ForEachEntity(_destroyEntityAction);
            _mouseExitFilter.ForEachEntity(_destroyEntityAction);
            _mouseDownFilter.ForEachEntity(_destroyEntityAction);
            _mouseUpFilter.ForEachEntity(_destroyEntityAction);
            _mouseUpAsButtonFilter.ForEachEntity(_destroyEntityAction);
        }
    }
}