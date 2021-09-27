using System;
using GoDoTest.Assertions;
using GoDoTest.Exceptions;
using static GoDoTest.Assertions.Equality;

namespace GoDoTest.Matchers {
  public static class Should {
    /// <summary>
    ///   Function that represents the constraint "the value of <c>actual</c> should be <c>expected</c>".
    /// </summary>
    // public static void ShouldBe<T>(this object actual, object expected) {
    //   // if (actual.GetType()) { }
    //
    //   switch (expected) {
    //     case IMatcher<object> match: {
    //       ShouldMatch(actual, match);
    //       break;
    //     }
    //     default: {
    //       AssertionCounter.Inc();
    //       AreEqual(actual, expected)?.Let(ErrorCollector.CollectOrThrow);
    //       break;
    //     }
    //   }
    // }


    // private static bool InvokeMatcher(object actual, Func<object, bool> matcher) => throw new NotImplementedException();

    public static void ShouldBe(this double actual, double expected, double delta = 1e-10) {
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