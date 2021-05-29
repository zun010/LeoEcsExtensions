using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

namespace Zun010.LeoEcsExtensions
{
    public abstract class LeoEcsSystemGroup : IEcsInitSystem, IEcsRunSystem, IEcsDestroySystem
    {
        private readonly List<IEcsInitSystem> _initSystems = new List<IEcsInitSystem>();
        private readonly List<IEcsRunSystem> _runSystems = new List<IEcsRunSystem>();
        private readonly List<IEcsDestroySystem> _destroySystems = new List<IEcsDestroySystem>();
        
        public void Init()
        {
            foreach (var system in _initSystems)
                system.Init();
        }

        public void Run()
        {
            foreach (var system in _runSystems)
                system.Run();
        }

        public void Destroy()
        {
            foreach (var system in _destroySystems)
                system.Destroy();
        }

        public void AddSystemToGroup(IEcsSystem system)
        {
            if (system is IEcsInitSystem initSystem)
                _initSystems.Add(initSystem);

            if (system is IEcsRunSystem runSystem)
                _runSystems.Add(runSystem);

            if (system is IEcsDestroySystem destroySystem)
                _destroySystems.Add(destroySystem);

            Debug.Log($"Init systems count: {_initSystems.Count}");
            Debug.Log($"Run systems count: {_runSystems.Count}");
            Debug.Log($"Destroy systems count: {_destroySystems.Count}");
        }
    }
}