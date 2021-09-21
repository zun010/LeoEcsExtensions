# LeoEcsExtensions
LeoEcsExtensions is a set of extensions for the LeoECS framework, such as UnityBridge, Conversion workflow and others.

# Content
* [Installation](#installation)
* [ExtensionMethods](#extensionmethods)
* [UnityBridge](#unitybridge)
   * [Collision and Trigger detection](#collision-and-trigger-detection)
   * [EventSystem](#eventsystem)
   * [MonoBehaviour events](#monobehaviour-events)
   * [2D Physics](#physycs2d-events)
   * [Raycasting](#raycasting)
* [Conversion workflow](#conversion-workflow)

# Installation

### PackageManager method
0. Make sure that you have LeoECS installed, otherwise ![install it](https://github.com/Leopotam/ecs#installation).
1. Open the PackageManager window in Unity.
2. Click on the plus sign and click `Add package from Git URL...`

    ![изображение](https://user-images.githubusercontent.com/30114587/120119313-b379d900-c19f-11eb-8681-1def9acf9f2d.png)

3. Enter the link `https://github.com/zun010/LeoEcsExtensions.git` in the input field and click `Add`.

    ![изображение](https://user-images.githubusercontent.com/30114587/120119337-e7ed9500-c19f-11eb-8e72-f2633ea6aa57.png)

4. After installation, add the dependency to your Assembly Definition and the package will be ready to use.

    ![изображение](https://user-images.githubusercontent.com/30114587/120119498-a4475b00-c1a0-11eb-86d6-b334e52caeba.png)

### Manifest.json method
You can add a dependency via the `Packages/manifest.json` file. To do this, open it for editing and add the following line
<br>
```"com.zun010.leoecsextensions": "https://github.com/zun010/LeoEcsExtensions.git",```


# ExtensionMethods
### EcsEntity NewEntityWith&lt;T&gt;(this EcsWorld world)

This method creates a new entity with a component of type T. This method calls the `EcsEntity.Get<T>()` method. This can be useful when you need to create an entity with a single tag component that does not contain any data inside. 
For example:
```c#
var entity = _world.NewEntityWith<RequestCreateEnemyTag>();
```

### EcsEntity NewEntityWith&lt;T&gt;(this EcsWorld world, T component)
This method creates a new entity with the component passed through the parameter. This method calls the `EcsEntity.Replace()` method. This can be used when you need to create a new entity, with a single component containing some data.
For example:
```c#
var requestComponent = new RequestCreateEnemyWithDataComponent
{
    Name = "Enemy",
    Health = 100,
    BehaviourType = EnemyBehaviourType.Agressive
};
var entity = _world.NewEntityWith(requestComponent);
```

### void ForEachEntity(this EcsFilter filter, Action&lt;EcsEntity&gt; action)
This method executes the Action passed through the parameter for each entity from the filter. For example:
```c#
public sealed class ExampleSystem : IEcsRunSystem
{
    private readonly EcsFilter<DestroyEnemyTag> _destroyEnemyFilter = null;
    
    private readonly Action<EcsEntity> _destroyEnemyAction = 
        entity => enemy.Destroy();
    
    public void Run()
    {
        if (_destroyEnemyFilter.IsEmpty())
            return;
    
        _destroyEnemyFilter.ForEachEntity(_destroyEnemyAction);
    }
}
```

### void ForAllFirstComponent&lt;T&gt;(this EcsFilter&lt;T&gt; filter, Action&lt;T&gt; action)
This method executes the Action passed through the parameter for each component obtained using `Get1()` from the filter. This can be useful when you need to do something with a single component in the filter.
For example:
```c#
public sealed class ExampleSystem : IEcsRunSystem
{
    private readonly EcsWorld _world = null;
    private readonly EcsFilter<RequestCreateEnemyWithDataComponent> _createEnemyFilter = null;
    
    private readonly Action<RequestCreateEnemyWithDataComponent> _createEnemyAction = 
        enemyData =>
        {
            var enemyComponent = new EnemyComponent
            {
                Name = enemyData.Name,
                Health = enemyData.Health,
                BehaviourType = enemyData.BehaviourType
            };

            _world.NewEntityWith(enemyComponent);
        };
    
    public void Run()
    {
        if (_createEnemyFilter.IsEmpty())
            return;
    
        _createEnemyFilter.ForAllFirstComponent(_createEnemyAction);
    }
}
```

# UnityBridge

UnityBridge  is a bridge between Unity and ECS, allowing you to work with collisions, triggers, and the EventSystem as components in ECS.

## How to use
You need to add to the end of `EcsSystems` the systems required for UnityBridge to work. The easiest way to do this is to use the static `AddAllUnityBridgeSystemsTo` method of the `UnityBridge` class. For example:
```c#
private void Init()
{
    _world = new EcsWorld();
    _updateSystems = new EcsSystems(_world, "UpdateSystems");

    UnityBridge.AddAllUnityBridgeSystemsTo(_updateSystems);
            
    _updateSystems.Init();
}
```

If you only need to use EventSystem or Physics, you can use the static methods `AddEventSystemBridgeSystemsTo` and `AddPhysicsBridgeSystemsTo` in a similar way.

## Collision and Trigger detection
To work with collision and trigger detection, the systems responsible for this will create entities with the necessary components with a lifetime of one frame.

These components are:
```
CollisionEnterEvent
CollisionExitEvent
CollisionStayEvent

TriggerEnterEvent
TriggerExitEvent
TriggerStayEvent

CollisionEnter2dEvent
CollisionExit2dEvent
CollisionStay2dEvent

TriggerEnter2dEvent
TriggerExit2dEvent
TriggerStay2dEvent
```

First, you need to add tracker components to the object that you want to track. To handle physics events, these are the following components:
```
CollisionEnterTracker
CollisionExitTracker
CollisionStayTracker

TriggerEnterTracker
TriggerExitTracker
TriggerStayTracker

CollisionEnter2dTracker
CollisionExit2dTracker
CollisionStay2dTracker

TriggerEnter2dTracker
TriggerExit2dTracker
TriggerStay2dTracker
```

After that, you will need to use `EcsFilter`s to catch the events. For example:
```c#
public sealed class ExampleSystem : IEcsRunSystem
{
    private readonly EcsFilter<TriggerEnterEvent> _triggerEnterFilter = null;
    
    public void Run()
    {
        if (_triggerEnterFilter.IsEmpty())
            return;

        foreach (var index in _triggerEnterFilter)
        {
            var triggerEnterEvent = _triggerEnterFilter.Get1(index);
            var sender = triggerEnterEvent = triggerEnterEvent.Sender;
            var gameObjectName = sender.name;
            
            Debug.Log($"GameObject named {gameObjectName} entered the trigger.");
        }
    }
}
```

## EventSystem
Working with EventSystem events is similar to working with Physics events. For each event generated by the EventSystem, a new entity is created with a component that provides data for this event.

These components are:
```
PointerEnterEvent
PointerExitEvent
PointerDownEvent
PointerUpEvent
PointerClickEvent

BeginDragEvent
EndDragEvent
DragEvent
DropEvent
```

First, you need to add tracker components to the object that you want to track. To handle EventSystem events, these are the following components:
```
PointerEnterTracker
PointerExitTracker
PointerDownTracker
PointerUpTracker
PointerClickTracker

BeginDragTracker
EndDragTracker
DragTracker
DropTracker
```

Just like when working with Physics, you need to use `EcsFilter`s to get the components. For example:
```c#
public sealed class ExampleSystem : IEcsRunSystem
{
    private readonly EcsFilter<PointerClickEvent> _pointerClickFilter = null;
    
    public void Run()
    {
        if (_pointerClickFilter.IsEmpty())
            return;

        foreach (var index in _pointerClickFilter)
        {
            var pointerClickEvent = _pointerClickFilter.Get1(index);
            var sender = pointerClickEvent.Sender;
            var clickedObjectName = sender.name;
            
            Debug.Log($"You clicked on a GameObject named {clickedObjectName}.");
        }
    }
}
```

## MonoBehaviour events
Working with MonoBehaviour events is similar to working with Physics and EventSystem events. For each event generated by the MonoBehaviour, a new entity is created with a component that provides data for this event.

These components are:
```
MouseEnterEvent
MouseExitEvent
MouseDownEvent
MouseUpEvent
MouseUpAsButtonEvent
```

First, you need to add tracker components to the object that you want to track. To handle MonoBehaviour events, these are the following components:
```
MouseEnterTracker
MouseExitTracker
MouseDownTracker
MouseUpTracker
MouseUpAsButtonTracker
```

Just like when working with Physics and EventSystem bridge, you need to use `EcsFilter`s to get the components. For example:
```c#
public sealed class ExampleSystem : IEcsRunSystem
{
    private readonly EcsFilter<MouseEnterEvent> _mouseEnterFilter = null;
    
    public void Run()
    {
        if (_mouseEnterFilter.IsEmpty())
            return;

        foreach (var index in _mouseEnterFilter)
        {
            var mouseEnterEvent = _mouseEnterFilter.Get1(index);
            var sender = mouseEnterEvent.Sender;
            var clickedObjectName = sender.name;
            
            Debug.Log($"You just entered mouse on a GameObject named {clickedObjectName}.");
        }
    }
}
```

## Raycasting
There are two systems that launch raycasts: `RaycastSystem` and `RaycastAllSystem`. In order for these systems to make a raycast, you need to create an entity with the `RaycastRequestComponent` and `RaycastAllRequestComponent` components, respectively.
<br>
<br>
After the systems responsible for the raycast are executed, the response component is added to the entity with the request component. These components are `RaycastResultComponent` and `RaycastAllResultComponent`.
<br>
The entity with the request component at the end of the frame will be deleted, as will the components that provide the Physics and EventSystem events.
<br>
<br>
The following example will help you understand how it works.

### Single raycast
Creating a system for requesting a raycast:
```c#
public sealed class RequestRaycastSystem : IEcsRunSystem
{
    private readonly EcsWorld _world = null;
    
    public void Run()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var distance = float.PositiveInfinity;
            var layerMask = LayerMask.GetMask("Default");
            
            var entity = _world.NewEntity();
            var raycastRequestComponent = new RaycastRequestComponent
            {
                Ray = ray,
                Distance = distance,
                LayerMask = layerMask
            };
            entity.Replace(raycastRequestComponent);
        }
    }
}
```

Creating a system that receives the result of the raycast:
```c#
public sealed class ResolveRaycastSystem : IEcsRunSystem
{
    private readonly EcsFilter<RaycastRequestComponent, RaycastResultComponent> _raycastFilter = null;
    
    public void Run()
    {
        if (_raycastFilter.IsEmpty())
            return;

        var raycastResultComponent = _raycastFilter.Get2(0);
        var raycastHit = raycastResultComponent.RaycastHit;
        var hitedObjectName = raycastHit.collider.name;
        
        Debug.Log($"You hit on a GameObject named {hitedObjectName}");
    }
}
```

Adding systems to EcsSystems in the following order:
```c#
_updateSystems
    .Add(new RequestRaycastSystem())
    .Add(new RaycastSystem())
    .Add(new ResolveRaycastSystem());
```

### RaycastAll
Creating a system for requesting a raycast:
```c#
public sealed class RequestRaycastAllSystem : IEcsRunSystem
{
    private readonly EcsWorld _world = null;

    private readonly RaycastHit[] _raycastHits = new RaycastHit[8];

    public void Run()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var distance = float.PositiveInfinity;
            var layerMask = LayerMask.GetMask("Default");
            
            var entity = _world.NewEntity();
            var raycastAllRequestComponent = new RaycastAllRequestComponent
            {
                Ray = ray,
                Distance = distance,
                LayerMask = layerMask,
                RaycastHits = _raycastHits
            };
            entity.Replace(raycastAllRequestComponent);
        }
    }
}
```

Creating a system that receives the result of the raycast:
```c#
public sealed class ResolveRaycastAllSystem : IEcsRunSystem
{
    private readonly EcsFilter<RaycastAllRequestComponent, RaycastAllResultComponent> _raycastFilter = null;
    
    public void Run()
    {
        if (_raycastFilter.IsEmpty())
            return;

        var raycastResultComponent = _raycastFilter.Get2(0);
        var hitsCount = raycastResultComponent.HitsCount;
        var raycastHits = raycastResultComponent.RaycastHits;

        for (var i = 0; i < hitsCount; i++)
        {
            var hitedObjectName = raycastHits[i].collider.name;
            Debug.Log($"You hit on a GameObject named {hitedObjectName}");
        }
    }
}
```

Adding systems to EcsSystems in the following order:
```c#
_updateSystems
    .Add(new RequestRaycastAllSystem())
    .Add(new RaycastAllSystem())
    .Add(new ResolveRaycastAllSystem());
```


# Conversion workflow
_Coming soon..._