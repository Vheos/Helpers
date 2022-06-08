#if UNITY
namespace Vheos.Helpers.UnityObjects;
using UnityEngine.SceneManagement;
using Vheos.Helpers.Math;

static public class Extensions_GameObject
{
    // Various
    static public void Activate(this GameObject t)
    => t.SetActive(true);
    static public void Deactivate(this GameObject t)
    => t.SetActive(false);
    static public bool IsActive(this GameObject t)
    => t.activeSelf;
    static public bool IsActiveInHierarchy(this GameObject t)
    => t.activeInHierarchy;

    #region HIERARCHY SETTERS
    /// <summary> Places this object at the root of the hierarchy </summary>
    static public void Unparent(this GameObject @this, bool retainWorldTransform = false)
    => @this.transform.SetParent(null, retainWorldTransform);
    /// <summary> Moves this object to the root of the chosen scene </summary>
    static public void MoveToScene(this GameObject @this, Scene scene)
    {
        if (@this.gameObject.scene == scene)
            return;

        @this.Unparent();
        SceneManager.MoveGameObjectToScene(@this, scene);
    }
    #endregion
    #region HIERARCHY SETTERS, GAMEOBJECT
    /// <summary> Attaches this objects to a's parent. </summary>
    /// <remarks> If a is a root object, moves this object to the root of a's scene </remarks>
    static public void BecomeSiblingOf(this GameObject @this, GameObject a, bool retainWorldTransform = false)
    {
        if (a.transform.parent.TryNonNull(out var targetParent))
            @this.transform.SetParent(targetParent, retainWorldTransform);
        else
            SceneManager.MoveGameObjectToScene(@this, a.scene);
    }
    /// <summary> Attaches this object to a. </summary>
    static public void BecomeChildOf(this GameObject @this, GameObject a, bool retainWorldTransform = false)
    => @this.transform.SetParent(a.transform, retainWorldTransform);
    #endregion
    #region HIERARCHY SETTERS, COMPONENT
    /// <summary> Attaches this objects to a's parent. </summary>
    static public void BecomeSiblingOf(this GameObject @this, Component a, bool retainWorldTransform = false)
    => @this.BecomeSiblingOf(a.gameObject, retainWorldTransform);
    /// <summary> Attaches this object to a. </summary>
    static public void BecomeChildOf(this GameObject @this, Component a, bool retainWorldTransform = false)
    => @this.BecomeChildOf(a.gameObject, retainWorldTransform);
    #endregion


    #region HIERARCHY CHECKS
    /// <summary> Checks whether this object is at the topmost level in the hierarchy. </summary>
    static public bool IsAtRoot(this GameObject @this)
    => @this.transform.parent == null;
    /// <summary> Checks whether this object has a parent. </summary>
    static public bool HasParent(this GameObject @this)
    => @this.transform.parent != null;
    /// <summary> Checks whether this object has a child. </summary>
    static public bool HasAnyChild(this GameObject @this)
    => @this.transform.childCount > 0;
    #endregion
    #region HIERARCHY CHECKS, GAMEOBJECT
    /// <summary> Checks whether this object is right above a in the heirarchy. </summary>
    static public bool IsParentOf(this GameObject @this, GameObject a)
    => @this.transform == a.transform.parent;
    /// <summary> Checks whether this object has the same parent as a. </summary>
    static public bool IsSiblingOf(this GameObject @this, GameObject a)
    => @this.transform.parent == a.transform.parent;
    /// <summary> Checks whether this object is right below a in the hierarchy. </summary>
    static public bool IsChildOf(this GameObject @this, GameObject a)
    => @this.transform.parent == a.transform;
    #endregion
    #region HIERARCHY CHECKS, COMPONENT
    /// <summary> Checks whether this object is right above a in the heirarchy. </summary>
    static public bool IsParentOf(this GameObject @this, Component a)
    => @this.IsParentOf(a.gameObject);
    /// <summary> Checks whether this object has the same parent as a. </summary>
    static public bool IsSiblingOf(this GameObject @this, Component a)
    => @this.IsSiblingOf(a.gameObject);
    /// <summary> Checks whether this object is right below a in the hierarchy. </summary>
    static public bool IsChildOf(this GameObject @this, Component a)
    => @this.IsChildOf(a.gameObject);
    #endregion


    #region HIERARCHY GETTERS
    /// <summary> Returns this object's child with name a. If it doesn'@this exist, returns null.</summary>
    static public GameObject FindChild(this GameObject @this, string a)
    {
        Transform child = @this.transform.Find(a);
        return child != null
            ? child.gameObject
            : null;
    }
    /// <summary> Returns component T attached to this object's child with name a. If it doesn'@this exist, returns null.</summary>
    static public T FindChild<T>(this GameObject @this, string a) where T : Component
    {
        Transform child = @this.transform.Find(a);
        return child != null
            ? child.GetComponent<T>()
            : null;
    }

    /// <summary> Returns this object's parent. If it doesn'@this exist, returns null. </summary>
    static public GameObject GetParent(this GameObject @this)
        => @this.HasParent()
        ? @this.transform.parent.gameObject
        : null;
    /// <summary> Returns an enumerable of this object's ancestors. </summary>
    static public IEnumerable<GameObject> GetAncestors(this GameObject @this)
    {
        for (Transform i = @this.transform.parent; i != null; i = i.parent)
            yield return i.gameObject;
    }
    /// <summary> Returns the topmost ancestor. </summary>
    static public GameObject GetRootAncestor(this GameObject @this)
    {
        Transform r = @this.transform;
        while (r.parent != null)
            r = r.parent;

        return r.gameObject;
    }
    #endregion


    #region SPATIAL, GAMEOBJECT
    /// <summary> Returns the distance between this object and a. </summary>
    static public float DistanceTo(this GameObject @this, GameObject a)
    => @this.transform.position.DistanceTo(a);
    /// <summary> Returns the offset from this object to a. </summary>
    static public Vector3 OffsetTo(this GameObject @this, GameObject a)
    => @this.transform.position.OffsetTo(a);
    /// <summary> Returns the offset from a to this object. </summary>
    static public Vector3 OffsetFrom(this GameObject @this, GameObject a)
    => @this.transform.position.OffsetFrom(a);
    /// <summary> Returns the direction from this object towards a. </summary>
    static public Vector3 DirectionTowards(this GameObject @this, GameObject a)
    => @this.transform.position.DirectionTowards(a);
    /// <summary> Returns the direction from a towards this object. </summary>
    static public Vector3 DirectionAwayFrom(this GameObject @this, GameObject a)
    => @this.transform.position.DirectionAwayFrom(a);
    /// <summary> Returns a ray starting at this object and going towards towards a. </summary>
    static public Ray RayTowards(this GameObject @this, GameObject a)
    => @this.transform.position.RayTowards(a);
    /// <summary> Returns a ray starting at a and going towards this object. </summary>
    static public Ray RayAwayFrom(this GameObject @this, GameObject a)
    => @this.transform.position.RayAwayFrom(a);

    /// <summary> Returns the on-screen distance between this object and a from camera b's perspective. </summary>
    static public float ScreenDistanceTo(this GameObject @this, GameObject a, Camera b)
    => @this.transform.position.ScreenDistanceTo(a, b);
    /// <summary> Returns the on-screen offset from this object to a from camera b's perspective. </summary>
    static public Vector2 ScreenOffsetTo(this GameObject @this, GameObject a, Camera b)
    => @this.transform.position.ScreenOffsetTo(a, b);
    /// <summary> Returns the on-screen offset from a to this object from camera b's perspective. </summary>
    static public Vector2 ScreenOffsetFrom(this GameObject @this, GameObject a, Camera b)
    => @this.transform.position.ScreenOffsetFrom(a, b);
    /// <summary> Returns the on-screen direction from this object towards a from camera b's perspective. </summary>
    static public Vector2 ScreenDirectionTowards(this GameObject @this, GameObject a, Camera b)
    => @this.transform.position.ScreenDirectionTowards(a, b);
    /// <summary> Returns the on-screen direction from a towards this object from camera b's perspective. </summary>
    static public Vector2 ScreenDirectionAwayFrom(this GameObject @this, GameObject a, Camera b)
    => @this.transform.position.ScreenDirectionAwayFrom(a, b);
    #endregion
    #region SPATIAL, COMPONENT
    /// <summary> Returns the distance between this object and a. </summary>
    static public float DistanceTo(this GameObject @this, Component a)
    => @this.transform.position.DistanceTo(a);
    /// <summary> Returns the offset from this object to a. </summary>
    static public Vector3 OffsetTo(this GameObject @this, Component a)
    => @this.transform.position.OffsetTo(a);
    /// <summary> Returns the offset from a to this object. </summary>
    static public Vector3 OffsetFrom(this GameObject @this, Component a)
    => @this.transform.position.OffsetFrom(a);
    /// <summary> Returns the direction from this object towards a. </summary>
    static public Vector3 DirectionTowards(this GameObject @this, Component a)
    => @this.transform.position.DirectionTowards(a);
    /// <summary> Returns the direction from a towards this object. </summary>
    static public Vector3 DirectionAwayFrom(this GameObject @this, Component a)
    => @this.transform.position.DirectionAwayFrom(a);
    /// <summary> Returns a ray starting at this object and going towards towards a. </summary>
    static public Ray RayTowards(this GameObject @this, Component a)
    => @this.transform.position.RayTowards(a);
    /// <summary> Returns a ray starting at a and going towards this object. </summary>
    static public Ray RayAwayFrom(this GameObject @this, Component a)
    => @this.transform.position.RayAwayFrom(a);

    /// <summary> Returns the on-screen distance between this object and a from camera b's perspective. </summary>
    static public float ScreenDistanceTo(this GameObject @this, Component a, Camera b)
    => @this.transform.position.ScreenDistanceTo(a, b);
    /// <summary> Returns the on-screen offset from this object to a from camera b's perspective. </summary>
    static public Vector2 ScreenOffsetTo(this GameObject @this, Component a, Camera b)
    => @this.transform.position.ScreenOffsetTo(a, b);
    /// <summary> Returns the on-screen offset from a to this object from camera b's perspective. </summary>
    static public Vector2 ScreenOffsetFrom(this GameObject @this, Component a, Camera b)
    => @this.transform.position.ScreenOffsetFrom(a, b);
    /// <summary> Returns the on-screen direction from this object towards a from camera b's perspective. </summary>
    static public Vector2 ScreenDirectionTowards(this GameObject @this, Component a, Camera b)
    => @this.transform.position.ScreenDirectionTowards(a, b);
    /// <summary> Returns the on-screen direction from a towards this object from camera b's perspective. </summary>
    static public Vector2 ScreenDirectionAwayFrom(this GameObject @this, Component a, Camera b)
    => @this.transform.position.ScreenDirectionAwayFrom(a, b);
    #endregion
    #region SPATIAL, VECTOR
    /// <summary> Returns the distance between this object and a. </summary>
    static public float DistanceTo(this GameObject @this, Vector3 a)
    => @this.transform.position.DistanceTo(a);
    /// <summary> Returns the offset from this object to a. </summary>
    static public Vector3 OffsetTo(this GameObject @this, Vector3 a)
    => @this.transform.position.OffsetTo(a);
    /// <summary> Returns the offset from a to this object. </summary>
    static public Vector3 OffsetFrom(this GameObject @this, Vector3 a)
    => @this.transform.position.OffsetFrom(a);
    /// <summary> Returns the direction from this object towards a. </summary>
    static public Vector3 DirectionTowards(this GameObject @this, Vector3 a)
    => @this.transform.position.DirectionTowards(a);
    /// <summary> Returns the direction from a towards this object. </summary>
    static public Vector3 DirectionAwayFrom(this GameObject @this, Vector3 a)
    => @this.transform.position.DirectionAwayFrom(a);
    /// <summary> Returns a ray starting at this object and going towards towards a. </summary>
    static public Ray RayTowards(this GameObject @this, Vector3 a)
    => @this.transform.position.RayTowards(a);
    /// <summary> Returns a ray starting at a and going towards this object. </summary>
    static public Ray RayAwayFrom(this GameObject @this, Vector3 a)
    => @this.transform.position.RayAwayFrom(a);

    /// <summary> Returns the on-screen distance between this object and a from camera b's perspective. </summary>
    static public float ScreenDistanceTo(this GameObject @this, Vector3 a, Camera b)
    => @this.transform.position.ScreenDistanceTo(a, b);
    /// <summary> Returns the on-screen offset from this object to a from camera b's perspective. </summary>
    static public Vector2 ScreenOffsetTo(this GameObject @this, Vector3 a, Camera b)
    => @this.transform.position.ScreenOffsetTo(a, b);
    /// <summary> Returns the on-screen offset from a to this object from camera b's perspective. </summary>
    static public Vector2 ScreenOffsetFrom(this GameObject @this, Vector3 a, Camera b)
    => @this.transform.position.ScreenOffsetFrom(a, b);
    /// <summary> Returns the on-screen direction from this object towards a from camera b's perspective. </summary>
    static public Vector2 ScreenDirectionTowards(this GameObject @this, Vector3 a, Camera b)
    => @this.transform.position.ScreenDirectionTowards(a, b);
    /// <summary> Returns the on-screen direction from a towards this object from camera b's perspective. </summary>
    static public Vector2 ScreenDirectionAwayFrom(this GameObject @this, Vector3 a, Camera b)
    => @this.transform.position.ScreenDirectionAwayFrom(a, b);
    #endregion


    #region COMPONENTS
    /// <summary> Checks whether this object has a component T. </summary>
    static public bool HasComponent<T>(this GameObject @this) where T : Component
    => @this.GetComponent<T>() != null;
    /// <summary> Checks whether this object's parent has a component T. </summary>
    static public bool ParentHasComponent<T>(this GameObject @this) where T : Component
    => @this.GetParentComponent<T>() != null;
    /// <summary> Checks whether any of this object's children has a component T. </summary>
    static public bool ChildHasComponent<T>(this GameObject @this) where T : Component
    => @this.GetChildComponent<T>() != null;
    /// <summary> Checks whether any of this object's siblings has a component T. </summary>
    static public bool SiblingHasComponent<T>(this GameObject @this) where T : Component
    => @this.GetSiblingComponent<T>() != null;

    /// <summary> Returns the first component of type T in this object's parent. </summary>
    static public T GetParentComponent<T>(this GameObject @this) where T : Component
        => @this.transform.parent.TryNonNull(out var parent)
        ? parent.GetComponent<T>()
        : null;
    /// <summary> Returns the first component of type T in any of this object's children. </summary>
    static public T GetChildComponent<T>(this GameObject @this) where T : Component
    {
        foreach (Transform child in @this.transform)
            if (Extensions_Component.TryGetComponent(child, out T component))    // explicit cast to prevent MissingMethodException in pre-2019.2 mods 
                return component;
        return null;
    }
    /// <summary> Returns the first component of type T in any of this object's siblings. </summary>
    static public T GetSiblingComponent<T>(this GameObject @this) where T : Component
    {
        foreach (Transform child in @this.transform.parent)
            if (child != @this.transform
            && Extensions_Component.TryGetComponent(child, out T component))   // explicit call to prevent MissingMethodException in pre-2019.2 mods 
                return component;
        return null;
    }

    /// <summary> Returns an enumerable of this object's parent's components of type T. </summary>
    static public IEnumerable<T> GetParentComponents<T>(this GameObject @this) where T : Component
    {
        foreach (Transform child in @this.transform)
            foreach (var component in child.GetComponents<T>())
                yield return component;
    }
    /// <summary> Returns an enumerable of this object's children's components of type T. </summary>
    static public IEnumerable<T> GetChildComponents<T>(this GameObject @this) where T : Component
    {
        foreach (Transform child in @this.transform)
            foreach (var component in child.GetComponents<T>())
                yield return component;
    }
    /// <summary> Returns an enumerable of this object's siblings' components of type T. </summary>
    static public IEnumerable<T> GetSiblingComponents<T>(this GameObject @this) where T : Component
    {
        foreach (Transform child in @this.transform.parent)
            if (child != @this.transform)
                foreach (var component in child.GetComponents<T>())
                    yield return component;
    }

    /// <summary> Returns an enumerable of this object's children's GameObjects. </summary>
    static public IEnumerable<GameObject> GetChildGameObjects(this GameObject @this)
    {
        foreach (Transform child in @this.transform)
            yield return child.gameObject;
    }
    /// <summary> Returns an enumerable of this object's siblings' GameObjects. </summary>
    static public IEnumerable<GameObject> GetSiblingGameObjects(this GameObject @this)
    {
        foreach (Transform child in @this.transform.parent)
            if (child != @this.transform)
                yield return child.gameObject;
    }

    /// <summary> Creates and returns a new game object as a child of this object, with name b. </summary>
    static public GameObject CreateChildGameObject(this GameObject @this, string name = null)
    {
        GameObject r = new();
        r.BecomeChildOf(@this);
        if (name != null)
            r.name = name;
        return r;
    }
    /// <summary> Creates a new game object as a child of this object, from prefab a and with name b. Returns its component of type T. </summary>
    static public T CreateChildComponent<T>(this GameObject @this, T a, string name = null) where T : Component
    {
        T newComponent = GameObject.Instantiate<T>(a, @this.transform);
        if (name != null)
            newComponent.name = name;
        return newComponent;
    }
    /// <summary> Creates a new game object as a child of this object, with name b. Adds a default component of type T, then returns it. </summary>
    static public T CreateChildComponent<T>(this GameObject @this, string name = null) where T : Component
    {
        GameObject newGO = new();
        newGO.BecomeChildOf(@this);
        T newComponent = newGO.AddComponent<T>();
        if (name != null)
            newGO.name = name;

        return newComponent;
    }

    /// <summary> Creates and returns a new game object as a sibling of this object, with name b. </summary>
    static public GameObject CreateSiblingGameObject(this GameObject @this, string name = null)
    {
        GameObject r = new();
        r.BecomeSiblingOf(@this);
        if (name != null)
            r.name = name;
        return r;
    }
    /// <summary> Creates a new game object as a sibling of this object, from prefab a and with name b. Returns its component of type T. </summary>
    /// <remarks> If called: <br/>
    /// • on a root object <br/>
    /// • during additive scene load <br/>
    /// • from <c><see langword="Awake"/>()</c> or <c><see langword="OnEnable"/>()</c> <br/>
    /// the component will get instantiated at the root of the recently active scene <br/>
    /// it will be moved to this object's scene only after its own <c><see langword="Awake"/>()</c> and <c><see langword="OnEnable"/>()</c> finish executing</remarks>
    static public T CreateSiblingComponent<T>(this GameObject @this, T a, string name = null) where T : Component
    {
        T newComponent = GameObject.Instantiate<T>(a, @this.transform.parent);
        if (@this.transform.parent == null)
            newComponent.gameObject.MoveToScene(@this.scene);

        if (name != null)
            newComponent.name = name;
        return newComponent;
    }
    /// <summary> Creates a new game object as a sibling of this object, with name b. Adds a default component of type T, then returns it. </summary>
    static public T CreateSiblingComponent<T>(this GameObject @this, string name = null) where T : Component
    {
        GameObject newGO = new();
        newGO.BecomeSiblingOf(@this);
        T newComponent = newGO.AddComponent<T>();
        if (name != null)
            newGO.name = name;

        return newComponent;
    }

    /// <summary> Returns component T attached to this object. If there's none, adds one. </summary>
    static public T GetOrAddComponent<T>(this GameObject @this) where T : Component
    {
        T component = @this.GetComponent<T>();
        return component != null
            ? component
            : @this.AddComponent<T>();
    }
    /// <summary> Returns enumerable of all components of type T in all of these GameObjects. </summary>
    static public IEnumerable<T> GetComponents<T>(this IEnumerable<GameObject> @this) where T : Component
    {
        foreach (var gameObject in @this)
            foreach (var component in gameObject.GetComponents<T>())
                yield return component;
    }

    /// <summary> Assigns component T to a. Returns whether any component was found. </summary>
    static public bool TryGetComponent<T>(this GameObject @this, out T a) where T : Component
    {
        a = @this.GetComponent<T>();
        return a != null;
    }
    #endregion


    #region DESTORY
    /// <summary> Destroys this object. </summary>
    static public void Destroy(this GameObject @this)
    {
        if (@this != null)
            GameObject.Destroy(@this);
    }
    /// <summary> Destroys this object instantly. </summary>
    static public void DestroyInstantly(this GameObject @this)
    {
        if (@this != null)
            GameObject.DestroyImmediate(@this);
    }
    /// <summary> Destroys these objects. </summary>
    static public void Destroy(this IEnumerable<GameObject> @this)
    {
        foreach (var gameObject in @this)
            if (gameObject != null)
                GameObject.Destroy(gameObject);
    }
    /// <summary> Destroys these objects instantly. </summary>
    static public void DestroyInstantly(this IEnumerable<GameObject> @this)
    {
        foreach (var gameObject in @this)
            if (gameObject != null)
                GameObject.DestroyImmediate(gameObject);
    }
    #endregion


    #region PHYSICS
    /// <summary> Makes this object react to (or ignore) physics forces. </summary>
    static public void SetPhysics(this GameObject @this, bool state)
    => @this.GetComponent<Rigidbody>().isKinematic = !state;
    /// <summary> Makes this object collide with (or ignore) other colliders. </summary>
    static public void SetCollisions(this GameObject @this, bool state)
    {
        foreach (var collider in @this.GetComponents<Collider>())
            collider.isTrigger = !state;
    }
    /// <summary> Resets a's local position, rotation and scale. </summary>
    static public void ResetLocalTransform(this GameObject @this)
    {
        @this.transform.localPosition = Vector3.zero;
        @this.transform.localRotation = Quaternion.identity;
        @this.transform.localScale = Vector3.one;
    }
    #endregion
    #region PHYSICS, GAMEOBJECT
    /// <summary> Makes this object collide with (or ignore) object a. </summary>
    static public void SetCollisionsWith(this GameObject @this, GameObject a, bool state)
    {
        foreach (var tCollider in @this.GetComponents<Collider>())
            foreach (var aCollider in a.GetComponents<Collider>())
                Physics.IgnoreCollision(tCollider, aCollider, !state);
    }
    /// <summary> Makes this object collide with (or ignore) objects from aCollection. </summary>
    static public void SetCollisionsWith(this GameObject @this, IEnumerable<GameObject> aCollection, bool state)
    {
        foreach (var a in aCollection)
            @this.SetCollisionsWith(a, state);
    }
    /// <summary> Copies a's transform. </summary>
    static public void CopyTransformFrom(this GameObject @this, GameObject a)
    => CopyLocalTransform(a.transform, @this.transform);
    /// <summary> Copies a's rigidbody. </summary>
    static public void CopyRigidbodyFrom(this GameObject @this, GameObject a, bool copyMassAndTensors = false)
    => CopyRigidbody(a.GetComponent<Rigidbody>(), @this.GetComponent<Rigidbody>(), copyMassAndTensors);
    #endregion
    #region PHYSICS, COMPONENT
    /// <summary> Makes this object collide with (or ignore) object a. </summary>
    static public void SetCollisionsWith(this GameObject @this, Component a, bool state)
    => @this.SetCollisionsWith(a.gameObject, state);
    /// <summary> Makes this object collide with (or ignore) objects from aCollection. </summary>
    static public void SetCollisionsWith(this GameObject @this, IEnumerable<Component> aCollection, bool state)
    {
        foreach (var a in aCollection)
            @this.SetCollisionsWith(a.gameObject, state);
    }
    /// <summary> Copies a's transform. </summary>
    static public void CopyTransformFrom(this GameObject @this, Component a)
    => @this.CopyTransformFrom(a.gameObject);
    /// <summary> Copies a's rigidbody. </summary>
    static public void CopyRigidbodyFrom(this GameObject @this, Component a, bool copyMassAndTensors = false)
    => @this.CopyRigidbodyFrom(a.gameObject, copyMassAndTensors);
    #endregion


    #region PRIVATE UTILITIES
    static private void CopyLocalTransform(Transform from, Transform to)
    {
        to.localPosition = from.localPosition;
        to.localRotation = from.localRotation;
        to.localScale = from.localScale;
    }
    static private void CopyRigidbody(Rigidbody from, Rigidbody to, bool copyMassAndTensors = false)
    {
        // Linear
        to.velocity = from.velocity;
        to.drag = from.drag;

        // Angular
        to.angularVelocity = from.angularVelocity;
        to.angularDrag = from.angularDrag;

        // Affected by
        to.isKinematic = from.isKinematic;
        to.useGravity = from.useGravity;
        to.freezeRotation = from.freezeRotation;
        to.constraints = from.constraints;

        // Collisions
        to.detectCollisions = from.detectCollisions;
        to.collisionDetectionMode = from.collisionDetectionMode;
        to.interpolation = from.interpolation;

        // Max & Min
        to.maxAngularVelocity = from.maxAngularVelocity;
        to.maxDepenetrationVelocity = from.maxDepenetrationVelocity;
        to.sleepThreshold = from.sleepThreshold;

        // Mass, Tensors, Solver percision
        to.mass = 1f;
        to.solverIterations = from.solverIterations;
        to.solverVelocityIterations = from.solverVelocityIterations;
        to.ResetCenterOfMass();
        to.ResetInertiaTensor();
        if (copyMassAndTensors)
        {
            to.mass = from.mass;
            to.centerOfMass = from.centerOfMass;
            to.inertiaTensor = from.inertiaTensor;
            to.inertiaTensorRotation = from.inertiaTensorRotation;
        }
    }
    #endregion
}
#endif