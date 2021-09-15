using System;
using GoDoTest.Exceptions;

namespace GoDoTest.Core {
  public static class Assert {
    public static void Equal(object expected, object actual) {
      if (expected != actual) {
        throw new AssertionException($"Expected {expected}, but got {actual}");
      }
    }
    
    public static void Equal(bool expected, bool actual) {
      if (expected != actual) {
        throw new AssertionException($"Expected {expected}, but got {actual}");
      }
    }
  }
}