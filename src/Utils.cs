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
    public static void Let<TI>(this TI self, Action<TI> block) {
      block(self);
    }
  }
}