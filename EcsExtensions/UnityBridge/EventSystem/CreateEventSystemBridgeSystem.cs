using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.UnityBridge
{
    public class CreateEventSystemBridgeSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        
        public void Init()
        {
            var gameObject = new GameObject("[EventSystemBridge]");
            var eventSystemBridge = gameObject.AddComponent<EventSystemBridge>();
            eventSystemBridge.SetWorld(_world);
        }
    }
}