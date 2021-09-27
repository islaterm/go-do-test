using System;
using Xunit.Sdk;

namespace GoDoTest.Core {
  /// <summary>
  ///   Static class containing helper attributes to annotate the test methods.
  /// </summary>
  public static class AttributeSpec {
    /// <summary>
    ///   Marks a function to be executed as a Test
    /// </summary>
    // [XunitTestCaseDiscoverer(typeof())]
    [AttributeUsage(AttributeTargets.Method)]
    public class TestAttribute : Attribute { }
  }
}