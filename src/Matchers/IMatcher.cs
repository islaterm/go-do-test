using System;

namespace GoDoTest.Matchers {
  /// <summary>
  ///   A Matcher is the main abstraction in the assertions library.
  ///   Implementations contain a single function, called <c>Test</c>, which accepts a value of type T and returns an
  ///   instance of  <see cref="MatcherResult" />.
  ///   This MatcherResult return value contains the state of the assertion after it has been evaluated.
  ///   A matcher will typically be invoked when used with the <c>Should</c> functions in the <see cref="Matchers" />
  ///   package.
  /// </summary>
  public interface IMatcher<in T> {
    /// <summary>
    ///   Tests a value against this matcher.
    /// </summary>
    /// <param name="actual">The value that's going to be tested.</param>
    /// <returns>The result of evaluating the marcher.</returns>
    MatcherResult Test(T actual);
  }

  public class MatcherResult {
    public MatcherResult(bool passed, string failureMessage, string negatedFailureMessage) =>
      throw new NotImplementedException("MatcherResult constructor not implemented");
  }
}