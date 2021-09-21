using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.UnityBridge
{
    public class CreatePhysics2dBridgeSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        
        public void Init()
        {
            var gameObject = new GameObject("[Physics2DBridge]");
            var physicsBridge = gameObject.AddComponent<Physics2dBridge>();
            physicsBridge.SetWorld(_world);
        }
    }
}