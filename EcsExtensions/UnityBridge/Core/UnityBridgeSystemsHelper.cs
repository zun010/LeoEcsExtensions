using Leopotam.Ecs;

namespace Zun010.UnityBridge
{
    public abstract partial class UnityBridge
    {
        public static void AddAllUnityBridgeSystemsTo(EcsSystems ecsSystems)
        {
            AddPhysicsBridgeSystemsTo(ecsSystems);
            AddEventSystemBridgeSystemsTo(ecsSystems);
            AddMonoBehaviourEventsBridgeSystemsTo(ecsSystems);
        }

        public static void AddPhysicsBridgeSystemsTo(EcsSystems ecsSystems)
        {
            ecsSystems
                .Add(new CreatePhysicsBridgeSystem())

                .OneFrame<CollisionEnterEvent>()
                .OneFrame<CollisionExitEvent>()
                .OneFrame<CollisionStayEvent>()

                .OneFrame<TriggerEnterEvent>()
                .OneFrame<TriggerExitEvent>()
                .OneFrame<TriggerStayEvent>()

                .OneFrame<RaycastRequest>()
                .OneFrame<RaycastResultComponent>()
                .OneFrame<RaycastAllRequest>()
                .OneFrame<RaycastAllResultComponent>();
        }

        public static void AddEventSystemBridgeSystemsTo(EcsSystems ecsSystems)
        {
            ecsSystems
                .Add(new CreateEventSystemBridgeSystem())
                
                .OneFrame<PointerEnterEvent>()
                .OneFrame<PointerExitEvent>()
                .OneFrame<PointerDownEvent>()
                .OneFrame<PointerUpEvent>()
                .OneFrame<PointerClickEvent>()
                
                .OneFrame<BeginDragEvent>()
                .OneFrame<EndDragEvent>()
                .OneFrame<DragEvent>()
                .OneFrame<DropEvent>();
        }

        public static void AddMonoBehaviourEventsBridgeSystemsTo(EcsSystems ecsSystems)
        {
            ecsSystems
                .Add(new CreateMonoBehaviourEventsBridgeSystem())
                
                .OneFrame<MouseEnterEvent>()
                .OneFrame<MouseExitEvent>()
                .OneFrame<MouseDownEvent>()
                .OneFrame<MouseUpEvent>()
                .OneFrame<MouseUpAsButtonEvent>();
        }
    }
}