using System;
using System.Collections.Generic;
using GoDoTest.Core.Internal;
using GoDoTest.Core.Spec;
using GoDoTest.Core.Test;
using GoDoTest.Engine.Dispatchers;

namespace GoDoTest.Engine.Launchers {
  public interface ITestLauncher {
    void Launch(Action<TestCase> run, List<TestCase> tests);
  }

  public static class TestLauncherFactory {
    public static ITestLauncher TestLauncher(ISpec spec) {
      var dispatcherFactory = Factories.CoroutineDispatcherFactory();
      var concurrentTests = spec.ResolvedConcurrentTests();
      return concurrentTests == Configuration.Sequential
        ? SequentialTestLauncher(dispatcherFactory)
        : ConcurrentTestLauncher(Math.Max(1, concurrentTests), dispatcherFactory);
    }
  }
}