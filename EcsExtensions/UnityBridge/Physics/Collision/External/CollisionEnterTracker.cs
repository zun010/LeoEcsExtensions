﻿using UnityEngine;

namespace Zun010.UnityBridge
{
    public class CollisionEnterTracker : UnityBridgeTracker<PhysicsBridge>
    {
        private void OnCollisionEnter(Collision other)
            => Bridge.CollisionEnter(gameObject, other);
    }
}