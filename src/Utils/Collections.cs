using System.Collections.Generic;
using System.Linq;
using GoDoTest.Ops;

namespace GoDoTest.Utils {
  [MustBeDocumented]
  public static class Collections {
    [MustBeDocumented]
    public static T FirstOrNull<T>(this IEnumerable<T> enumerable) where T : class {
      var a = enumerable as T[] ?? enumerable.ToArray();
      return a.IsEmpty() ? null : a.First();
    }

    [MustBeDocumented]
    public static bool IsEmpty<T>(this T[] ts) => ts.Length == 0;
  }
}