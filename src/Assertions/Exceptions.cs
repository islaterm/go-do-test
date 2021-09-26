using System;
using GoDoTest.Exceptions;

namespace GoDoTest.Assertions {
  public class Exceptions {
    /// <summary>
    /// Creates an <see cref="AssertionException"/> from the given message. 
    /// </summary>
    public static AssertionException CreateAssertionException(string message, Exception cause) =>
      throw new NotImplementedException();
  }
}