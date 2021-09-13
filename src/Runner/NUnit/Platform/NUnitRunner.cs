using System;
using System.Collections.Generic;
using NUnit.Framework.Internal;

namespace GoDoTest.Runner.NUnit.Platform {
  /// <summary>
  ///   Base for creating custom test runners.
  /// </summary>
  public interface INUnitRunner {
    /// <summary>
    ///   Called before a group of properties on a type are checked.
    /// </summary>
    void OnStartFixture(Type type);

    /// <summary>
    ///   Called whenever arguments are generated and after the test is run.
    /// </summary>
    void OnArguments(int nTest, List<object> args, Func<int, List<object>, string> every);

    /// <summary>
    ///   Called on a successful shrink.
    /// </summary>
    void OnShrink(List<object> args, Func<List<object>, string> everyShrink);

    /// <summary>
    ///   Called whenever all tests are done, either True, False or Exhausted.
    /// </summary>
    void OnFinished(string _, TestResult testResult);
  }
}