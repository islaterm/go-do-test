using System;

namespace GoDoTest {
  public static class Utils {
    /// <summary>
    ///   Calls the specified function block with <c>this</c> value as its argument and returns its result.
    /// </summary>
    public static void Let<TI>(this TI self, Action<TI> block) => block(self);

    // ReSharper disable once RedundantCast
    public static string Show<T>(this T self) => self == null ? "<null>" : (self as object).ToString();
    
  }
}