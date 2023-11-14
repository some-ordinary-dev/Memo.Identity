using System.Collections.Concurrent;

namespace Memo.Identity;

public class MemoIdentity
{
    private static ConcurrentDictionary<Type, object> _memo = new ConcurrentDictionary<Type, object>();

    public static T Default<T>()
    {
        var obj = _memo.GetOrAdd(typeof(T), () => default(T));
        return (T)obj;
    }
}
