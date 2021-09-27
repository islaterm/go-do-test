using System;
using System.Collections;
using System.Text.RegularExpressions;
using GoDoTest.Exceptions;
using static GoDoTest.Assertions.Equality;

namespace GoDoTest.Matchers {
  /// <summary>
  ///   Matcher for relations like 'A [relation] B'.
  ///   An example can be 'A is equal to B'.
  /// </summary>
  public static class Is {
    public class EqualTo<T> : IMatcher<T> {
      private readonly T _expected;

      public EqualTo(T expected) => _expected = expected;

      public MatcherResult Test(T actual) {
        // if (actual == null && _expected == null) {
        //   return null;
        // }
        //
        // if (actual == null && _expected != null) {
        //   return new ExceptionMatcherResult(new AssertionException($"Expected {_expected.Show()} but actual was null"));
        // }
        //
        // if (actual != null && _expected == null) {
        //   return new ExceptionMatcherResult(new AssertionException($"Expected null but actual was {actual.Show()}"));
        // }
        //
        // if (actual != null && _expected != null) {
        //   if (actual as object is IDictionary) {
        //     var equal = new MapEq(_expected as IDictionary);
        //     return equal.Test(actual as IDictionary);
        //   }
        //
        //   switch (actual) {
        //     case Regex actualRegex when _expected is Regex expectedRedex: {
        //       var equal = new RegexEq(expectedRedex);
        //       return equal.Test(actualRegex);
        //     }
        //     case string actualStr when _expected is string expectedStr: {
        //       var equal = new StringEq(expectedStr);
        //       break;
        //     }
        //   }
        // }
        //
        throw new NotImplementedException();
      }
    }
    // public static Func<double, bool> EqualTo(double y, double delta = 1e-10) => x => Math.Abs(x - y) < delta;

    // public static Func<object, bool> EqualTo(object y) =>
    //   throw new NotImplementedException("EqualTo for objects is not defined.");
  }
}