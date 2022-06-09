#if UNITY
namespace Vheos.Helpers.UnityObjects;
using UnityEngine.SceneManagement;

public static class Extensions_Component
{
    // Various
    public static void Activate(this Component t)
    => t.gameObject.SetActive(true);
    public static void Deactivate(this Component t)
    => t.gameObject.SetActive(false);
    public static bool IsActive(this Component t)
    => t.gameObject.activeSelf;
    public static bool IsActiveInHierarchy(this Component t)
    => t.gameObject.activeInHierarchy;
    public static void ToggleActive(this Component t)
    => t.gameObject.ToggleActive();
    public static void SetActive(this Component t, bool state)
    => t.gameObject.SetActive(state);

    #region HIERARCHY SETTERS
    /// <summary> Places this object at the root of the hierarchy. </summary>
    public static void Unparent(this Component @this, bool retainWorldTransform = false)
    => @this.gameObject.Unparent(retainWorldTransform);
    /// <summary> Moves this object to the root of the chosen scene </summary>
    public static void MoveToScene(this Component @this, Scene scene)
    => @this.gameObject.MoveToScene(scene);

    #endregion
    #region HIERARCHY SETTERS, GAMEOBJECT
    /// <summary> Attaches this objects to a's parent.gameObject. </summary>
    public static void BecomeSiblingOf(this Component @this, UnityEngine.GameObject a, bool retainWorldTransform = false)
    => @this.gameObject.BecomeSiblingOf(a, retainWorldTransform);
    /// <summary> Attaches this object to a. </summary>
    public static void BecomeChildOf(this Component @this, UnityEngine.GameObject a, bool retainWorldTransform = false)
    => @this.gameObject.BecomeChildOf(a, retainWorldTransform);
    #endregion
    #region HIERARCHY SETTERS, COMPONENT
    /// <summary> Attaches this objects to a's parent.gameObject. </summary>
    public static void BecomeSiblingOf(this Component @this, Component a, bool retainWorldTransform = false)
    => @this.gameObject.BecomeSiblingOf(a, retainWorldTransform);
    /// <summary> Attaches this object to a. </summary>
    public static void BecomeChildOf(this Component @this, Component a, bool retainWorldTransform = false)
    => @this.gameObject.BecomeChildOf(a, retainWorldTransform);
    #endregion


    #region HIERARCHY CHECKS
    /// <summary> Checks whether this object is at the topmost level in the hierarchy. </summary>
    public static bool IsAtRoot(this Component @this)
    => @this.gameObject.IsAtRoot();
    /// <summary> Checks whether this object has a parent.gameObject. </summary>
    public static bool HasParent(this Component @this)
    => @this.gameObject.HasParent();
    /// <summary> Checks whether this object has a child. </summary>
    public static bool HasAnyChild(this Component @this)
    => @this.gameObject.HasAnyChild();
    #endregion
    #region HIERARCHY CHECKS, GAMEOBJECT
    /// <summary> Checks whether this object is right above a in the heirarchy. </summary>
    public static bool IsParentOf(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.IsParentOf(a);
    /// <summary> Checks whether this object has the same parent as a. </summary>
    public static bool IsSiblingOf(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.IsSiblingOf(a);
    /// <summary> Checks whether this object is right below a in the hierarchy. </summary>
    public static bool IsChildOf(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.IsChildOf(a);
    #endregion
    #region HIERARCHY CHECKS, COMPONENT
    /// <summary> Checks whether this object is right above a in the heirarchy. </summary>
    public static bool IsParentOf(this Component @this, Component a)
    => @this.gameObject.IsParentOf(a);
    /// <summary> Checks whether this object has the same parent as a. </summary>
    public static bool IsSiblingOf(this Component @this, Component a)
    => @this.gameObject.IsSiblingOf(a);
    /// <summary> Checks whether this object is right below a in the hierarchy. </summary>
    public static bool IsChildOf(this Component @this, Component a)
    => @this.gameObject.IsChildOf(a);
    #endregion


    #region HIERARCHY GETTERS
    /// <summary> Returns this object's child with name a. If it doesn'@this exist, returns null.</summary>
    public static UnityEngine.GameObject FindChild(this Component @this, string a)
    => @this.gameObject.FindChild(a);
    /// <summary> Returns component T attached to this object's child with name a. If it doesn'@this exist, returns null.</summary>
    public static T FindChild<T>(this Component @this, string a) where T : Component
    => @this.gameObject.FindChild<T>(a);

    /// <summary> Returns this object's parent.gameObject. If it doesn'@this exist, returns null. </summary>
    public static UnityEngine.GameObject GetParent(this Component @this)
    => @this.gameObject.GetParent();
    /// <summary> Returns an enumerable of this object's ancestors. </summary>
    public static IEnumerable<UnityEngine.GameObject> GetAncestors(this Component @this)
    => @this.gameObject.GetAncestors();
    /// <summary> Returns the topmost ancestor. </summary>
    public static UnityEngine.GameObject GetRootAncestor(this Component @this)
    => @this.gameObject.GetRootAncestor();
    #endregion


    #region SPATIAL, GAMEOBJECT
    /// <summary> Returns the distance between this object and a. </summary>
    public static float DistanceTo(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.DistanceTo(a);
    /// <summary> Returns the offset from this object to a. </summary>
    public static Vector3 OffsetTo(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.OffsetTo(a);
    /// <summary> Returns the offset from a to this object.gameObject. </summary>
    public static Vector3 OffsetFrom(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.OffsetFrom(a);
    /// <summary> Returns the direction from this object towards a. </summary>
    public static Vector3 DirectionTowards(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.DirectionTowards(a);
    /// <summary> Returns the direction from a towards this object.gameObject. </summary>
    public static Vector3 DirectionAwayFrom(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.DirectionAwayFrom(a);
    /// <summary> Returns a ray starting at this object and going towards towards a. </summary>
    public static Ray RayTowards(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.RayTowards(a);
    /// <summary> Returns a ray starting at a and going towards this object. </summary>
    public static Ray RayAwayFrom(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.RayAwayFrom(a);

    /// <summary> Returns the on-screen distance between this object and a from camera b's perspective. </summary>
    public static float ScreenDistanceTo(this Component @this, UnityEngine.GameObject a, Camera b)
    => @this.gameObject.ScreenDistanceTo(a, b);
    /// <summary> Returns the on-screen offset from this object to a from camera b's perspective. </summary>
    public static Vector2 ScreenOffsetTo(this Component @this, UnityEngine.GameObject a, Camera b)
    => @this.gameObject.ScreenOffsetTo(a, b);
    /// <summary> Returns the on-screen offset from a to this object from camera b's perspective. </summary>
    public static Vector2 ScreenOffsetFrom(this Component @this, UnityEngine.GameObject a, Camera b)
    => @this.gameObject.ScreenOffsetFrom(a, b);
    /// <summary> Returns the on-screen direction from this object towards a from camera b's perspective. </summary>
    public static Vector2 ScreenDirectionTowards(this Component @this, UnityEngine.GameObject a, Camera b)
    => @this.gameObject.ScreenDirectionTowards(a, b);
    /// <summary> Returns the on-screen direction from a towards this object from camera b's perspective. </summary>
    public static Vector2 ScreenDirectionAwayFrom(this Component @this, UnityEngine.GameObject a, Camera b)
    => @this.gameObject.ScreenDirectionAwayFrom(a, b);
    #endregion
    #region SPATIAL, COMPONENT
    /// <summary> Returns the distance between this object and a. </summary>
    public static float DistanceTo(this Component @this, Component a)
    => @this.gameObject.DistanceTo(a);
    /// <summary> Returns the offset from this object to a. </summary>
    public static Vector3 OffsetTo(this Component @this, Component a)
    => @this.gameObject.OffsetTo(a);
    /// <summary> Returns the offset from a to this object.gameObject. </summary>
    public static Vector3 OffsetFrom(this Component @this, Component a)
    => @this.gameObject.OffsetFrom(a);
    /// <summary> Returns the direction from this object towards a. </summary>
    public static Vector3 DirectionTowards(this Component @this, Component a)
    => @this.gameObject.DirectionTowards(a);
    /// <summary> Returns the direction from a towards this object.gameObject. </summary>
    public static Vector3 DirectionAwayFrom(this Component @this, Component a)
    => @this.gameObject.DirectionAwayFrom(a);
    /// <summary> Returns a ray starting at this object and going towards towards a. </summary>
    public static Ray RayTowards(this Component @this, Component a)
    => @this.gameObject.RayTowards(a);
    /// <summary> Returns a ray starting at a and going towards this object. </summary>
    public static Ray RayAwayFrom(this Component @this, Component a)
    => @this.gameObject.RayAwayFrom(a);

    /// <summary> Returns the on-screen distance between this object and a from camera b's perspective. </summary>
    public static float ScreenDistanceTo(this Component @this, Component a, Camera b)
    => @this.gameObject.ScreenDistanceTo(a, b);
    /// <summary> Returns the on-screen offset from this object to a from camera b's perspective. </summary>
    public static Vector2 ScreenOffsetTo(this Component @this, Component a, Camera b)
    => @this.gameObject.ScreenOffsetTo(a, b);
    /// <summary> Returns the on-screen offset from a to this object from camera b's perspective. </summary>
    public static Vector2 ScreenOffsetFrom(this Component @this, Component a, Camera b)
    => @this.gameObject.ScreenOffsetFrom(a, b);
    /// <summary> Returns the on-screen direction from this object towards a from camera b's perspective. </summary>
    public static Vector2 ScreenDirectionTowards(this Component @this, Component a, Camera b)
    => @this.gameObject.ScreenDirectionTowards(a, b);
    /// <summary> Returns the on-screen direction from a towards this object from camera b's perspective. </summary>
    public static Vector2 ScreenDirectionAwayFrom(this Component @this, Component a, Camera b)
    => @this.gameObject.ScreenDirectionAwayFrom(a, b);
    #endregion
    #region SPATIAL, VECTOR
    /// <summary> Returns the distance between this object and a. </summary>
    public static float DistanceTo(this Component @this, Vector3 a)
    => @this.gameObject.DistanceTo(a);
    /// <summary> Returns the offset from this object to a. </summary>
    public static Vector3 OffsetTo(this Component @this, Vector3 a)
    => @this.gameObject.OffsetTo(a);
    /// <summary> Returns the offset from a to this object.gameObject. </summary>
    public static Vector3 OffsetFrom(this Component @this, Vector3 a)
    => @this.gameObject.OffsetFrom(a);
    /// <summary> Returns the direction from this object towards a. </summary>
    public static Vector3 DirectionTowards(this Component @this, Vector3 a)
    => @this.gameObject.DirectionTowards(a);
    /// <summary> Returns the direction from a towards this object.gameObject. </summary>
    public static Vector3 DirectionAwayFrom(this Component @this, Vector3 a)
    => @this.gameObject.DirectionAwayFrom(a);
    /// <summary> Returns a ray starting at this object and going towards towards a. </summary>
    public static Ray RayTowards(this Component @this, Vector3 a)
    => @this.gameObject.RayTowards(a);
    /// <summary> Returns a ray starting at a and going towards this object. </summary>
    public static Ray RayAwayFrom(this Component @this, Vector3 a)
    => @this.gameObject.RayAwayFrom(a);

    /// <summary> Returns the on-screen distance between this object and a from camera b's perspective. </summary>
    public static float ScreenDistanceTo(this Component @this, Vector3 a, Camera b)
    => @this.gameObject.ScreenDistanceTo(a, b);
    /// <summary> Returns the on-screen offset from this object to a from camera b's perspective. </summary>
    public static Vector2 ScreenOffsetTo(this Component @this, Vector3 a, Camera b)
    => @this.gameObject.ScreenOffsetTo(a, b);
    /// <summary> Returns the on-screen offset from a to this object from camera b's perspective. </summary>
    public static Vector2 ScreenOffsetFrom(this Component @this, Vector3 a, Camera b)
    => @this.gameObject.ScreenOffsetFrom(a, b);
    /// <summary> Returns the on-screen direction from this object towards a from camera b's perspective. </summary>
    public static Vector2 ScreenDirectionTowards(this Component @this, Vector3 a, Camera b)
    => @this.gameObject.ScreenDirectionTowards(a, b);
    /// <summary> Returns the on-screen direction from a towards this object from camera b's perspective. </summary>
    public static Vector2 ScreenDirectionAwayFrom(this Component @this, Vector3 a, Camera b)
    => @this.gameObject.ScreenDirectionAwayFrom(a, b);
    #endregion


    #region COMPONENTS
    /// <inheritdoc cref="GameObject.HasComponent{T}(UnityEngine.GameObject)"/>
    public static bool HasComponent<T>(this Component @this) where T : Component
    => @this.gameObject.HasComponent<T>();
    /// <inheritdoc cref="GameObject.ParentHasComponent{T}(UnityEngine.GameObject)"/>
    public static bool ParentHasComponent<T>(this Component @this) where T : Component
    => @this.gameObject.ParentHasComponent<T>();
    /// <inheritdoc cref="GameObject.ChildHasComponent{T}(UnityEngine.GameObject)"/>
    public static bool ChildHasComponent<T>(this Component @this) where T : Component
    => @this.gameObject.ChildHasComponent<T>();

    /// <inheritdoc cref="GameObject.CreateSiblingGameObject(UnityEngine.GameObject, string)"/>
    public static UnityEngine.GameObject CreateSiblingGameObject(this Component @this, string name = null)
    => @this.gameObject.CreateSiblingGameObject(name);
    /// <inheritdoc cref="GameObject.CreateSiblingComponent{T}(UnityEngine.GameObject, T, string)"/>
    public static T CreateSiblingComponent<T>(this Component @this, T a, string name = null) where T : Component
    => @this.gameObject.CreateSiblingComponent<T>(a, name);
    /// <inheritdoc cref="GameObject.CreateSiblingComponent{T}(UnityEngine.GameObject, string)"/>
    public static T CreateSiblingComponent<T>(this Component @this, string name = null) where T : Component
    => @this.gameObject.CreateSiblingComponent<T>(name);

    /// <inheritdoc cref="GameObject.CreateChildGameObject(UnityEngine.GameObject, string)"/>
    public static UnityEngine.GameObject CreateChildGameObject(this Component @this, string name = null)
    => @this.gameObject.CreateChildGameObject(name);
    /// <inheritdoc cref="GameObject.CreateChildComponent{T}(UnityEngine.GameObject, T, string)"/>
    public static T CreateChildComponent<T>(this Component @this, T a, string name = null) where T : Component
    => @this.gameObject.CreateChildComponent<T>(a, name);
    /// <inheritdoc cref="GameObject.CreateChildComponent{T}(UnityEngine.GameObject, string)"/>
    public static T CreateChildComponent<T>(this Component @this, string name = null) where T : Component
    => @this.gameObject.CreateChildComponent<T>(name);

    /// <summary> Returns component T attached to this object. If there's none, adds one. </summary>
    public static T GetOrAddComponent<T>(this Component @this) where T : Component
    => @this.gameObject.GetOrAddComponent<T>();
    /// <summary> Returns an enumerable of this object's children's GameObjects. </summary>
    public static IEnumerable<UnityEngine.GameObject> GetChildGameObjects(this Component @this)
    => @this.gameObject.GetChildGameObjects();
    /// <summary> Returns an enumerable of this object's siblings' GameObjects. </summary>
    public static IEnumerable<UnityEngine.GameObject> GetSiblingGameObjects(this Component @this)
    => @this.gameObject.GetSiblingGameObjects();
    /// <summary> Returns an enumerable of this object's children's components. </summary>
    public static IEnumerable<T> GetChildComponents<T>(this Component @this) where T : Component
    => @this.gameObject.GetChildComponents<T>();
    /// <summary> Returns an enumerable of this object's siblings' components. </summary>
    public static IEnumerable<T> GetSiblingComponents<T>(this Component @this) where T : Component
    => @this.gameObject.GetSiblingComponents<T>();
    /// <summary> Returns enumerable of GameObjects of all of these components. </summary>
    public static IEnumerable<UnityEngine.GameObject> GetGameObjects<T>(this IEnumerable<T> @this) where T : Component
    {
        foreach (var component in @this)
            yield return component.gameObject;
    }

    /// <summary> Returns the first component of type T in this object's children. </summary>
    public static T GetChildComponent<T>(this Component @this) where T : Component
     => @this.gameObject.GetChildComponent<T>();
    /// <summary> Returns the first component of type T in this object's siblings. </summary>
    public static T GetSiblingComponent<T>(this Component @this) where T : Component
    => @this.gameObject.GetSiblingComponent<T>();

    /// <summary> Assigns component T to a. Returns whether any component was found. </summary>
    public static bool TryGetComponent<T>(this Component @this, out T a) where T : Component
    => Extensions_GameObject.TryGetComponent(@this.gameObject, out a);   // explicit cast to prevent MissingMethodException in pre-2019.2 mods 
    #endregion


    #region DESTORY
    /// <summary> Destroys this component. </summary>
    public static void Destroy(this Component @this)
    {
        if (@this != null)
            UnityEngine.GameObject.Destroy(@this);
    }
    /// <summary> Destroys this component instantly. </summary>
    public static void DestroyInstantly(this Component @this)
    {
        if (@this != null)
            UnityEngine.GameObject.DestroyImmediate(@this);
    }
    /// <summary> Destroys these components. </summary>
    public static void Destroy<T>(this IEnumerable<T> @this) where T : Component
    {
        foreach (var component in @this)
            if (component != null)
                UnityEngine.GameObject.Destroy(component);
    }
    /// <summary> Destroys these components instantly. </summary>
    public static void DestroyInstantly<T>(this IEnumerable<T> @this) where T : Component
    {
        foreach (var component in @this)
            if (component != null)
                UnityEngine.GameObject.DestroyImmediate(component);
    }
    /// <summary> Destroys this component's object. </summary>
    public static void DestroyObject(this Component @this)
    {
        if (@this != null)
            UnityEngine.GameObject.Destroy(@this.gameObject);
    }
    /// <summary> Destroys this component's object. </summary>
    public static void DestroyObjectInstantly(this Component @this)
    {
        if (@this != null)
            UnityEngine.GameObject.DestroyImmediate(@this.gameObject);
    }
    /// <summary> Destroys these components' objects. </summary>
    public static void DestroyObject<T>(this IEnumerable<T> @this) where T : Component
    {
        foreach (var component in @this)
            if (component != null)
                UnityEngine.GameObject.Destroy(component.gameObject);
    }
    /// <summary> Destroys these components' objects instantly. </summary>
    public static void DestroyObjectInstantly<T>(this IEnumerable<T> @this) where T : Component
    {
        foreach (var component in @this)
            if (component != null)
                UnityEngine.GameObject.DestroyImmediate(component);
    }
    #endregion


    #region PHYSICS
    /// <summary> Makes this object react to (or ignore) physics forces. </summary>
    public static void SetPhysics(this Component @this, bool state)
    => @this.gameObject.SetPhysics(state);
    /// <summary> Makes this object collide with (or ignore) other colliders. </summary>
    public static void SetCollisions(this Component @this, bool state)
    => @this.gameObject.SetCollisions(state);
    /// <summary> Resets a's local position, rotation and scale. </summary>
    public static void ResetLocalTransform(this Component @this)
    => @this.gameObject.ResetLocalTransform();
    #endregion
    #region PHYSICS, GAMEOBJECT
    /// <summary> Makes this object collide with (or ignore) object a. </summary>
    public static void SetCollisionsWith(this Component @this, UnityEngine.GameObject a, bool state)
    => @this.gameObject.SetCollisionsWith(a, state);
    /// <summary> Makes this object collide with (or ignore) objects from aCollection. </summary>
    public static void SetCollisionsWith(this Component @this, IEnumerable<UnityEngine.GameObject> aCollection, bool state)
    => @this.gameObject.SetCollisionsWith(aCollection, state);
    /// <summary> Copies a's transform. </summary>
    public static void CopyTransformFrom(this Component @this, UnityEngine.GameObject a)
    => @this.gameObject.CopyTransformFrom(a);
    /// <summary> Copies a's rigidbody. </summary>
    public static void CopyRigidbodyFrom(this Component @this, UnityEngine.GameObject a, bool copyMassAndTensors = false)
    => @this.gameObject.CopyRigidbodyFrom(a, copyMassAndTensors);
    #endregion
    #region PHYSICS, COMPONENT
    /// <summary> Makes this object collide with (or ignore) object a. </summary>
    public static void SetCollisionsWith(this Component @this, Component a, bool state)
    => @this.gameObject.SetCollisionsWith(a, state);
    /// <summary> Makes this object collide with (or ignore) objects from aCollection. </summary>
    public static void SetCollisionsWith(this Component @this, IEnumerable<Component> aCollection, bool state)
    => @this.gameObject.SetCollisionsWith(aCollection, state);
    /// <summary> Copies a's transform. </summary>
    public static void CopyTransformFrom(this Component @this, Component a)
    => @this.gameObject.CopyTransformFrom(a);
    /// <summary> Copies a's rigidbody. </summary>
    public static void CopyRigidbodyFrom(this Component @this, Component a, bool copyMassAndTensors = false)
    => @this.gameObject.CopyRigidbodyFrom(a, copyMassAndTensors);
    #endregion
}
#endif