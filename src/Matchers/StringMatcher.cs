using System;

namespace GoDoTest.Matchers {
  public abstract class StringMatcher : IMatcher<string> {
    public abstract MatcherResult Test(string actual);

    /// <summary>
    ///   Returns an instance of a matcher that tests if a string starts with a given prefix.
    /// </summary>
    public static StartWithMatcher StartWith(string prefix) {
      var matcher = new StartWithMatcher(prefix);
      return matcher;
    }
  }

  public class StartWithMatcher : StringMatcher {
    private readonly string _prefix;

    public StartWithMatcher(string prefix) {
      _prefix = prefix;
    }

    public override MatcherResult Test(string actual) {
      var ok = actual.StartsWith(_prefix);
      var msg = $"{actual} should start with {_prefix}";
      var notMsg = $"{actual} should not start with {_prefix}";
      if (ok) {
        return new MatcherResult(true, msg, notMsg);
      }

      var k = 0;
      var hi = Math.Min(actual.Length, _prefix.Length);
      while (k < hi && actual[k] == _prefix[k]) {
        k++;
      }

      msg += $" (diverged at index {k})";
      return new MatcherResult(false, msg, notMsg);
    }
  }
}