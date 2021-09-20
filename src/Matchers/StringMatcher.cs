using System;

namespace GoDoTest.Matchers {
  public abstract class StringMatcher : IMatcher {
    public void Test<T>(T value) => throw new NotImplementedException();

    public static Func<string, bool> StartWith(string prefix) =>
      throw new NotImplementedException("StringMatcher.StartWith not implemented");
  }
}