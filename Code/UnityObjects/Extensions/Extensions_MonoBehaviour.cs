#if UNITY
namespace Vheos.Helpers.UnityObjects;

static public class Extensions_MonoBehaviour
{
    // Various
    static public void Enable(this MonoBehaviour t)
    => t.enabled = true;
    static public void Disable(this MonoBehaviour t)
    => t.enabled = false;

    // Coroutines
    public static Coroutine ExecuteAfterUpdate(this MonoBehaviour @this, Action action)
        => @this.StartCoroutine(AfterUpdate(action));
    public static Coroutine ExecuteAfterFixedUpdate(this MonoBehaviour @this, Action action)
        => @this.StartCoroutine(AfterFixedUpdate(action));
    public static Coroutine ExecuteAfterCurrentUpdate(this MonoBehaviour @this, Action action)
        => @this.StartCoroutine(AfterCurrentUpdate(action));
    public static Coroutine ExecuteAfterSeconds(this MonoBehaviour @this, float delay, Action action)
        => @this.StartCoroutine(AfterSeconds(delay, action));
    public static Coroutine ExecuteAfterRealSeconds(this MonoBehaviour @this, float delay, Action action)
        => @this.StartCoroutine(AfterRealSeconds(delay, action));
    public static Coroutine ExecuteAfterCheck(this MonoBehaviour @this, Func<bool> test, Action action)
        => @this.StartCoroutine(AfterCheck(test, action));
    public static Coroutine ExecuteWhile(this MonoBehaviour @this, Func<bool> test, Action action, Action finalAction = null)
        => @this.StartCoroutine(While(test, action, finalAction));
    public static Coroutine ExecuteWhileNot(this MonoBehaviour @this, Func<bool> test, Action action, Action finalAction = null)
        => @this.StartCoroutine(WhileNot(test, action, finalAction));
    public static Coroutine ExecuteUntil(this MonoBehaviour @this, Func<bool> test, Action action, Action finalAction = null)
        => @this.StartCoroutine(Until(test, action, finalAction));
    public static Coroutine ExecuteUntilNot(this MonoBehaviour @this, Func<bool> test, Action action, Action finalAction = null)
        => @this.StartCoroutine(UntilNot(test, action, finalAction));

    // Privates
    static private IEnumerator AfterUpdate(Action action)
    {
        yield return new WaitForEndOfFrame();
        action();
    }
    static private IEnumerator AfterFixedUpdate(Action action)
    {
        yield return new WaitForFixedUpdate();
        action();
    }
    static private IEnumerator AfterCurrentUpdate(Action action)
    {
        yield return Time.inFixedTimeStep ? new WaitForFixedUpdate() : new WaitForEndOfFrame();
        action();
    }
    static private IEnumerator AfterSeconds(float delay, Action action)
    {
        yield return new WaitForSeconds(delay);
        action();
    }
    static private IEnumerator AfterRealSeconds(float delay, Action action)
    {
        yield return new WaitForSecondsRealtime(delay);
        action();
    }
    static private IEnumerator AfterCheck(Func<bool> check, Action action)
    {
        yield return new WaitUntil(check);
        action();
    }
    static private IEnumerator While(Func<bool> test, Action action, Action finalAction = null)
    {
        while (test())
        {
            action();
            yield return null;
        }
        finalAction?.Invoke();
    }
    static private IEnumerator WhileNot(Func<bool> test, Action action, Action finalAction = null)
    {
        while (!test())
        {
            action();
            yield return null;
        }
        finalAction?.Invoke();
    }
    static private IEnumerator Until(Func<bool> test, Action action, Action finalAction = null)
    {
        do
        {
            action();
            yield return null;
        }
        while (!test());
        finalAction?.Invoke();
    }
    static private IEnumerator UntilNot(Func<bool> test, Action action, Action finalAction = null)
    {
        do
        {
            action();
            yield return null;
        }
        while (test());
        finalAction?.Invoke();
    }
}
#endif