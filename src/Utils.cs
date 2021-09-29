using System;
using System.Collections.Generic;

namespace GoDoTest {
  public static class Utils {
    /// <summary>
    ///   Calls the specified function block with <c>this</c> value as its argument and returns its result.
    /// </summary>
    public static TR Let<TI, TR>(this TI self, Func<TI, TR> block) => block(self);

    // ReSharper disable once RedundantCast
    public static string Show<T>(this T self) => self == null ? "<null>" : (self as object).ToString();

    [MustBeDocumented]
    [ComingSoon]
    public static IEnumerable<T> FilterIsInstance<T>(this IEnumerable<object> list) =>
      throw new NotImplementedException();

    [MustBeDocumented]
    [ComingSoon]
    public static TR Map<TI, TR>(this TI self, Func<TI, TR> func) => throw new NotImplementedException();

    [MustBeDocumented]
    [ComingSoon]
    public static T GetOrElse<T>(this T self, Func<T> f) => throw new NotImplementedException();
  }

  /// <summary>
  ///   This attribute marks a method or class that lacks appropriate documentation.
  /// </summary>
  public class MustBeDocumentedAttribute : Attribute { }

  /// <summary>
  ///   This attribute marks a method that's currently unimplemented or incomplete and will be implemented on the
  ///   future.
  /// </summary>
  public class ComingSoonAttribute : Attribute { }
}