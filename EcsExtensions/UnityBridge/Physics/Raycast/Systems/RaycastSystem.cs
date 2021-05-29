using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.UnityBridge
{
    public class RaycastSystem : IEcsRunSystem
    {
        private readonly EcsFilter<RaycastRequestComponent>.Exclude<RaycastResultComponent> _requestFilter = null;

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

                if (Physics.Raycast(ray, out var hit, distance, layerMask))
                {
                    var resultComponent = new RaycastResultComponent
                    {
                        RaycastHit = hit
                    };
                    entity.Replace(resultComponent);
                }
            }
        }
    }
}