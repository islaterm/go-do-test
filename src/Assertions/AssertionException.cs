using System;

namespace GoDoTest.Assertions {
  public class AssertionException : Exception {
    /// <summary>
    ///   Constructs a new <c>AssertionError</c> with the specified detail message and cause.
    ///   Note that the detail message associated with <c>cause</c> is <i>not</i> automatically incorporated in this
    ///   error's detail message.
    /// </summary>
    /// <param name="message">The detail message, may be <c>null</c></param>
    /// <param name="cause">The cause, may be <c>null</c></param>
    public AssertionException(string message, Exception cause) : base(message, cause) { }
  }
}