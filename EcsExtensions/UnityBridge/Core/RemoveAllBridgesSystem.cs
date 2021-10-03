using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.UnityBridge
{
    public class RemoveAllBridgesSystem : IEcsDestroySystem
    {
        public void Destroy()
        {
            var bridges = Object.FindObjectsOfType<UnityBridge>();
            foreach (var bridge in bridges)
            {
                Object.DestroyImmediate(bridge.gameObject);
            }
        }
    }
}