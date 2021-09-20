using System;
using System.Diagnostics.CodeAnalysis;
using GoDoTest.Exceptions;

namespace GoDoTest.Assertions {
  /// <summary>
  ///   The  <see cref="Equality" /> static class compares two values for equality, returning an
  ///   <see cref="AssertionException" /> if they are not equal, or null if they are equal.
  /// </summary>
  public static class Equality {
    [SuppressMessage("ReSharper", "RedundantCast")]
    public static Exception AreEqual(object actual, object expected) {
      
      return null;
    }

    public static Exception AreEqual(double expected, double actual, double delta) =>
      AssertDoublesAreEqual(expected, actual, delta);

    private static Exception AssertDoublesAreEqual(double expected, double actual, double delta) {
      
      throw new NotImplementedException();
    }
  }
}