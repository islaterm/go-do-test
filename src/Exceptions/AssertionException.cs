using System;

namespace GoDoTest.Exceptions {
  public class AssertionException : Exception {
    public AssertionException(string message) : base(message) { }
  }
}