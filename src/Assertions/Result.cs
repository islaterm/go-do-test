using System;
using GoDoTest.Mpp;

namespace GoDoTest.Assertions {
  public static class Result {
    /// <summary>
    ///   Creates the most appropriate error from the given message, wrapping in clue context(s) if any are set.
    /// </summary>
    public static AssertionException Failure(string message) => Failure(message, null);

    /// <summary>
    ///   Creates an <see cref="AssertionException" /> from the given message, wrapping in clue context(s)
    ///   if any are set, and setting the cause as <c>cause</c> on platforms that supported nested exceptions.
    /// </summary>
    private static AssertionException Failure(string message, Exception cause) =>
      StackTraces.CleanStackTrace(
        Exceptions.CreateAssertionException(ErrorCollector.ClueContextAsString() + message, cause));
  }
}