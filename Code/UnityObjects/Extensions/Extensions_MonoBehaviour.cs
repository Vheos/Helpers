#if UNITY
namespace Vheos.Helpers.UnityObjects;

public static class Extensions_MonoBehaviour
{
    // Various
    public static void Enable(this MonoBehaviour t)
    => t.enabled = true;
    public static void Disable(this MonoBehaviour t)
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
    private static IEnumerator AfterUpdate(Action action)
    {
        yield return new WaitForEndOfFrame();
        action();
    }
    private static IEnumerator AfterFixedUpdate(Action action)
    {
        yield return new WaitForFixedUpdate();
        action();
    }
    private static IEnumerator AfterCurrentUpdate(Action action)
    {
        yield return Time.inFixedTimeStep ? new WaitForFixedUpdate() : new WaitForEndOfFrame();
        action();
    }
    private static IEnumerator AfterSeconds(float delay, Action action)
    {
        yield return new WaitForSeconds(delay);
        action();
    }
    private static IEnumerator AfterRealSeconds(float delay, Action action)
    {
        yield return new WaitForSecondsRealtime(delay);
        action();
    }
    private static IEnumerator AfterCheck(Func<bool> check, Action action)
    {
        yield return new WaitUntil(check);
        action();
    }
    private static IEnumerator While(Func<bool> test, Action action, Action finalAction = null)
    {
        while (test())
        {
            action();
            yield return null;
        }
        finalAction?.Invoke();
    }
    private static IEnumerator WhileNot(Func<bool> test, Action action, Action finalAction = null)
    {
        while (!test())
        {
            action();
            yield return null;
        }
        finalAction?.Invoke();
    }
    private static IEnumerator Until(Func<bool> test, Action action, Action finalAction = null)
    {
        do
        {
            action();
            yield return null;
        }
        while (!test());
        finalAction?.Invoke();
    }
    private static IEnumerator UntilNot(Func<bool> test, Action action, Action finalAction = null)
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