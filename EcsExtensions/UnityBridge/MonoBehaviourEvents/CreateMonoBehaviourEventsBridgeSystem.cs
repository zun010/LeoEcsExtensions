using Leopotam.Ecs;
using UnityEngine;
using Zun010.UnityBridge;

namespace Zun010.UnityBridge
{
    public class CreateMonoBehaviourEventsBridgeSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;
        
        public void Init()
        {
            var gameObject = new GameObject("[MonoBehaviourEventsBridge]");
            var monoBehaviourEventsBridge = gameObject.AddComponent<MonoBehaviourEventsBridge>();
            monoBehaviourEventsBridge.SetWorld(_world);
        }
    }
}