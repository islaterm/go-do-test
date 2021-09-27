using System;

namespace GoDoTest.Assertions {
  public static class Exceptions {
    /// <summary>
    /// Creates an <see cref="AssertionException"/> from the given message. 
    /// </summary>
    public static AssertionException CreateAssertionException(string message, Exception cause) =>
      new AssertionException(message, cause);
  }
}