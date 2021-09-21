using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.UnityBridge
{
    public class RaycastAllSystem : IEcsRunSystem
    {
        private readonly EcsFilter<RaycastAllRequest> _requestFilter = null;

        public void Run()
        {
            if (_requestFilter.IsEmpty())
                return;

            foreach (var index in _requestFilter)
            {
                var raycastComponent = _requestFilter.Get1(index);
                var entity = _requestFilter.GetEntity(index);
                
                var ray = raycastComponent.Ray;
                var distance = raycastComponent.Distance;
                var layerMask = raycastComponent.LayerMask;
                var raycastHits = raycastComponent.RaycastHits;
                
                if (Physics.Raycast(ray, distance, layerMask))
                {
                    var count = Physics.RaycastNonAlloc(ray, raycastHits, distance, layerMask);
                    
                    var raycastAllResultComponent = new RaycastAllResultComponent
                    {
                        RaycastHits = raycastHits,
                        HitsCount = count
                    };
                    entity.Replace(raycastAllResultComponent);
                }
            }
        }
    }
}