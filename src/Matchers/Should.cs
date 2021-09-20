using System;
using System.Runtime.CompilerServices;
using Godot;
using GoDoTest.Assertions;
using GoDoTest.Core;
using GoDoTest.Exceptions;

namespace GoDoTest.Matchers {
  public static class Should {
    /// <summary>
    ///   Function that represents the constraint "the value of <c>actual</c> should be <c>expected</c>".
    /// </summary>
    public static object ShouldBe(this object actual, object expected) {
      var eq = InvokeMatcher(actual, Is.EqualTo(expected));
        if (!eq) {
          // TODO: Test collector
          throw new AssertionException($"Expected {expected}, but got {actual}");
        }
        return actual;
    }

    private static bool InvokeMatcher(object actual, Func<object,bool> matcher) {
      throw new NotImplementedException();
    }

    public static void ShouldBe(this double actual, double expected) { }

    public static void ShouldBe(this int actual, double expected) {
      InvokeMatcher(actual, Is.EqualTo(expected));
    }

    private static double InvokeMatcher(double value, Func<double, bool> matcher) {
      AssertionCounter.Inc();
      var result = matcher(value);
      if (!result) {
        throw new NotImplementedException("InvokeMatcher not implemented.");
      }
      return value;
    }

    public static void ShouldMatch<T>(this T expected, Func<T, bool> actual) { }
  }

  public interface IMatcher {
    void Test<T>(T value);
  }
}