using Leopotam.Ecs;

namespace Zun010.UnityBridge
{
    public abstract partial class UnityBridge
    {
        public static void AddAllUnityBridgeSystemsTo(EcsSystems ecsSystems)
        {
            AddPhysicsBridgeSystemsTo(ecsSystems);
            AddEventSystemBridgeSystemsTo(ecsSystems);
        }

        public static void AddPhysicsBridgeSystemsTo(EcsSystems ecsSystems)
        {
            ecsSystems
                .Add(new CreatePhysicsBridgeSystem())
                .Add(new DestroyCollisionDataEntitySystem())
                .Add(new DestroyTriggerDataEntitySystem())
                .Add(new DestroyRaycastRequestEntitySystem())
                .Add(new DestroyRaycastAllRequestEntitySystem());
        }

        public static void AddEventSystemBridgeSystemsTo(EcsSystems ecsSystems)
        {
            ecsSystems
                .Add(new CreateEventSystemBridgeSystem())
                .Add(new DestroyPointerEventsDataEntitySystem())
                .Add(new DestroyDragAndDropDataEntitySystem());
        }
    }
}