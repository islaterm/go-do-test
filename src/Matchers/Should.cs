using System;
using GoDoTest.Assertions;
using static GoDoTest.Assertions.Equality;

namespace GoDoTest.Matchers {
  public static class Should {
    /// <summary>
    ///   Performs a "should be" assertion like: <c>actual</c> should be <c>expected</c>.
    ///   If <c>expected</c> is an <see cref="IMatcher{T}" />, the the result is evaluated as a "should match" assertion.
    /// </summary>
    /// <seealso cref="ShouldMatch(object,GoDoTest.Matchers.IMatcher{object})" />
    /// <param name="actual">The value to test.</param>
    /// <param name="expected">The value or expression to match.</param>
    public static void ShouldBe(this object actual, object expected) {
      if (expected is IMatcher<object> matcher) {
        actual.ShouldMatch(matcher);
      } else {
        AssertionCounter.Inc();
        AreEqual(actual, expected)?.Let(ErrorCollector.CollectOrThrow);
      }
    }

    private static void ShouldBe(this double actual, double expected, double delta = 1e-10) {
      var error = AreEqualDouble(actual, expected, delta);
      AssertionCounter.Inc();
    }

    public static void ShouldBe(this int actual, double expected) {
      ((double) actual).ShouldBe(expected, 0);
    }

    private static double InvokeMatcher(double value, IMatcher<double> matcher) {
      AssertionCounter.Inc();
      var result = matcher.Test(value);
      throw new NotImplementedException();
      // if (!result) {
      //   throw new NotImplementedException("InvokeMatcher not implemented.");
      // }

      return value;
    }

    // public static void ShouldMatch(this object actual, IMatcher<object> expected) => InvokeMatcher(actual, expected);

    private static void ShouldMatch(this object actual, IMatcher<object> matcher) =>
      throw new NotImplementedException();

    public static void ShouldMatch(this string actual, StringMatcher matcher) {
      InvokeStringMatcher(actual, matcher);
    }

    private static string InvokeStringMatcher(string actual, StringMatcher matcher) {
      AssertionCounter.Inc();
      var result = matcher.Test(actual);
      if (!result.Passed) {
        ErrorCollector.CollectOrThrow(Result.Failure(result.FailureMessage));
      }

      return actual;
    }
  }
}