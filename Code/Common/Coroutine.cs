#if UNITY
namespace Vheos.Helpers.Common;

static public class Coroutine
{

    static public IEnumerator AfterUpdate(Action action)
    {
        yield return new WaitForEndOfFrame();
        action();
    }
    static public IEnumerator AfterFixedUpdate(Action action)
    {
        yield return new WaitForFixedUpdate();
        action();
    }
    static public IEnumerator AfterCurrentTimestep(Action action)
    {
        yield return Time.inFixedTimeStep ? new WaitForFixedUpdate() : new WaitForEndOfFrame();
        action();
    }
    static public IEnumerator AfterSeconds(float delay, Action action)
    {
        yield return new WaitForSeconds(delay);
        action();
    }
    static public IEnumerator AfterRealSeconds(float delay, Action action)
    {
        yield return new WaitForSecondsRealtime(delay);
        action();
    }
    static public IEnumerator AfterCheck(Func<bool> check, Action action)
    {
        yield return new WaitUntil(check);
        action();
    }
    static public IEnumerator While(Func<bool> test, Action action, Action finalAction = null)
    {
        while (test())
        {
            action();
            yield return null;
        }
        finalAction?.Invoke();
    }
}
#endif