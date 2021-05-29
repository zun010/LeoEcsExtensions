using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class StepCollisionDetectionSystem : IEcsRunSystem
    {
        private readonly EcsFilter<CollisionEnterComponent> _collisionEnterFilter = null;
        private readonly EcsFilter<CollisionExitComponent> _collisionExitFilter = null;
        private readonly EcsFilter<CollisionStayComponent> _collisionStayFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _collisionEnterFilter.ForAllEntity(_destroyEntityAction);
            _collisionExitFilter.ForAllEntity(_destroyEntityAction);
            _collisionStayFilter.ForAllEntity(_destroyEntityAction);
        }
    }
}