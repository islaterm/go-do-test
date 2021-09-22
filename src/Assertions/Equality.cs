using System;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;
using GoDoTest.Exceptions;
using GoDoTest.Matchers;

namespace GoDoTest.Assertions {
  /// <summary>
  ///   The  <see cref="Equality" /> static class compares two values for equality, returning an
  ///   <see cref="AssertionException" /> if they are not equal, or null if they are equal.
  /// </summary>
  public static class Equality {
    public static Exception AreEqual<T>(T? actual, T? expected) where T : unmanaged {
      // if (actual is obReferenceEquals(actual, expected)) {
      //   return null;
      // }

      if (actual == null) {
        return null;
      }

      if (actual == null) {
        return null;
      }

      throw new NotImplementedException();
    }

    public static Exception AreEqual(object actual, object expected) {
      if (ReferenceEquals(actual, expected)) { }

      throw new NotImplementedException();
    }

    public static Exception AreEqualDouble(double expected, double actual, double delta) =>
      AssertDoublesAreEqual(expected, actual, delta);

    private static Exception AssertDoublesAreEqual(double expected, double actual, double delta) =>
      !(Math.Abs(expected - actual) > delta)
        ? null
        : new AssertionException(
          $"Expected {expected.ToString(CultureInfo.InvariantCulture)} but was {actual.ToString(CultureInfo.InvariantCulture)}");

    public class MapEq : IMatcher<IDictionary> {
      public MapEq(IDictionary expected) => throw new NotImplementedException();

      public MatcherResult Test(IDictionary actual) => throw new NotImplementedException();
    }

    public class RegexEq : IMatcher<Regex> {
      public RegexEq(Regex expected) => throw new NotImplementedException();

      public MatcherResult Test(Regex actual) => throw new NotImplementedException();
    }
  }
}