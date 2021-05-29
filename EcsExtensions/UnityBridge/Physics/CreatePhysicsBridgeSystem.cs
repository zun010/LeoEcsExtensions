using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.UnityBridge
{
    public class CreatePhysicsBridgeSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        
        public void Init()
        {
            var gameObject = new GameObject("[PhysicsBridge]");
            var physicsBridge = gameObject.AddComponent<PhysicsBridge>();
            physicsBridge.SetWorld(_world);
        }
    }
}