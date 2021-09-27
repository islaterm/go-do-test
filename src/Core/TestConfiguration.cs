using System;

namespace GoDoTest.Core {
  public class TestConfiguration {
    /// <summary>
    /// Registers a callback to be executed before every <see cref="TestCase"/>.
    ///
    /// The TestCase about to be executed is provided as the parameter.
    /// </summary>
    /// <param name="f"></param>
    public static void BeforeTest(Action<TestCase> f) {
      RegisterListener();
    }
  }
}