using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.UnityBridge
{
    public abstract partial class UnityBridge : MonoBehaviour
    {
        protected EcsWorld World;

        internal void SetWorld(EcsWorld world)
        {
            World = world;
        }

        public static T FindBridge<T>() where T : UnityBridge
        {
            var bridge = FindObjectOfType<T>();
            
            if (!bridge)
                throw new MissingComponentException($"{typeof(T)} does not exist. " +
                    $"Maybe you forgot to initialize bridge creation system?");

            return bridge;
        }
    }
}