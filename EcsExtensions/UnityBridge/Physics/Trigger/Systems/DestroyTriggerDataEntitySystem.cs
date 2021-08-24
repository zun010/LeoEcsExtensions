using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class DestroyTriggerDataEntitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<TriggerEnterEvent> _triggerEnterFilter = null;
        private readonly EcsFilter<TriggerExitEvent> _triggerExitFilter = null;
        private readonly EcsFilter<TriggerStayEvent> _triggerStayFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _triggerEnterFilter.ForEachEntity(_destroyEntityAction);
            _triggerExitFilter.ForEachEntity(_destroyEntityAction);
            _triggerStayFilter.ForEachEntity(_destroyEntityAction);
        }
    }
}