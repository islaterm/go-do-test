using System;

namespace GoDoTest.Exceptions {
  public static class Result {
    public static AssertionException Failure(string message) => throw new NotImplementedException();
  }
}