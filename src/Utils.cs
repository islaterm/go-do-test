using System;

namespace GoDoTest {
  public static class Utils {
    /// <summary>
    ///   Calls the specified function block with <c>this</c> value as its argument and returns its result.
    /// </summary>
    public static TR Let<TI, TR>(this TI self, Func<TI, TR> block) => block(self);

    /// <summary>
    ///   Calls the specified function block with <c>this</c> value as its argument.
    /// </summary>
    public static void Let<T>(this T self, Action<T> block) => block(self);

    // ReSharper disable once RedundantCast
    public static string Show<T>(this T self) => self == null ? "<null>" : (self as object).ToString();

    public static string Invoke(this string s, Func<string> f) => f();
  }
}