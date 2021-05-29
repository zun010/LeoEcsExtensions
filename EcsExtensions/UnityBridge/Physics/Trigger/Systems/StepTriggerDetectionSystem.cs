using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class StepTriggerDetectionSystem : IEcsRunSystem
    {
        private readonly EcsFilter<TriggerEnterComponent> _triggerEnterFilter = null;
        private readonly EcsFilter<TriggerExitComponent> _triggerExitFilter = null;
        private readonly EcsFilter<TriggerStayComponent> _triggerStayFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _triggerEnterFilter.ForAllEntity(_destroyEntityAction);
            _triggerExitFilter.ForAllEntity(_destroyEntityAction);
            _triggerStayFilter.ForAllEntity(_destroyEntityAction);
        }
    }
}