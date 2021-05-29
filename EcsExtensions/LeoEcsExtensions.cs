using System;
using Leopotam.Ecs;

namespace Zun010.LeoEcsExtensions
{
    public static class LeoEcsExtensions
    {
        public static EcsEntity NewEntityWith<T>(this EcsWorld world)
            where T : struct
        {
            var entity = world.NewEntity();
            entity.Get<T>();

            return entity;
        }
        
        public static EcsEntity NewEntityWith<T>(this EcsWorld world, T component)
            where T : struct
        {
            var entity = world.NewEntity();
            entity.Replace(component);

            return entity;
        }

        public static void ForAllEntity(this EcsFilter filter, Action<EcsEntity> action)
        {
            foreach (var index in filter)
                action(filter.GetEntity(index));
        }
        
        public static void ForAllFirstComponent<T>(this EcsFilter<T> filter, Action<T> action)
            where T : struct
        {
            foreach (var index in filter)
                action(filter.Get1(index));
        }
    }
}