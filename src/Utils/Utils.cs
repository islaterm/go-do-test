using System;
using System.Collections.Generic;

namespace GoDoTest.Ops {
  public static class Utils {
    /// <summary>
    ///   Calls the specified function block with <c>this</c> value as its argument and returns its result.
    /// </summary>
    public static TR Let<TI, TR>(this TI self, Func<TI, TR> block) => block(self);

    // ReSharper disable once RedundantCast
    public static string Show<T>(this T self) => self == null ? "<null>" : (self as object).ToString();

    /// <summary>
    ///   Returns a list containing all elements that are instances of specified type parameter R.
    /// </summary>
    public static IEnumerable<T> FilterIsInstance<T>(this IEnumerable<object> enumerable) =>
      FilterIsInstanceTo(enumerable, new List<T>());

    /// <summary>
    ///   Appends all elements that are instances of specified type parameter R to the given <c>destination</c>.
    /// </summary>
    private static IEnumerable<T> FilterIsInstanceTo<T>(IEnumerable<object> enumerable, ICollection<T> destination) {
      foreach (var element in enumerable) {
        if (element is T e) {
          destination.Add(e);
        }
      }

      return destination;
    }

    // [MustBeDocumented]
    // [ComingSoon]
    // public static TR Map<TI, TR>(this TI self, Func<TI, TR> func) {
    //   if (self is None) {
    //     return self;
    //   }
    //
    //   if (self is Some) {
    //     return func(self.Value).Some();
    //   }
    // }

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