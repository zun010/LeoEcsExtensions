using System;
using Leopotam.Ecs;
using Zun010.LeoEcsExtensions;

namespace Zun010.UnityBridge
{
    public class DestroyRaycastAllRequestEntitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<RaycastAllRequestComponent> _raycastFilter = null;
        
        private readonly Action<EcsEntity> _destroyEntityAction = 
            entity => entity.Destroy();
        
        public void Run()
        {
            _raycastFilter.ForEachEntity(_destroyEntityAction);
        }
    }
}