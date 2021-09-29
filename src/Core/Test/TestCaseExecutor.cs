using System;
using GoDoTest.Assertions;
using GoDoTest.Engine.Dispatchers;

namespace GoDoTest.Core.Test {
  public class TestCaseExecutor {
    private readonly ITestCaseExecutorListener _listener;
    private readonly ICoroutineDispatcherFactory _defaultCoroutineDispatcherFactory;

    public TestCaseExecutor(ITestCaseExecutorListener listener,
      ICoroutineDispatcherFactory defaultCoroutineDispatcherFactory) {
      _listener = listener;
      _defaultCoroutineDispatcherFactory = defaultCoroutineDispatcherFactory;
    }

    // public TestResult Execute(TestCase testCase, TestContext context) {
    //   throw new NotImplementedException();
    // }
  }
}