using System;
using System.Collections.Generic;
using GoDoTest.Core.Test;
using GoDoTest.Engine.Dispatchers;

namespace GoDoTest.Engine.Launchers {
  /// <summary>
  ///   An <see cref="ITestLauncher" /> that launches tests concurrently.
  /// </summary>
  public class ConcurrentTestLauncher : ITestLauncher {
    /// <param name="maxConcurrent">The maximum number of coroutines to launch. Uses a semaphore to limit.</param>
    /// <param name="factory">an <see cref="ICoroutineDispatcherFactory" /> used to allocate dispatchers to tests.</param>
    public ConcurrentTestLauncher(int maxConcurrent, ICoroutineDispatcherFactory factory) { }

    public void Launch(Action<TestCase> run, List<TestCase> tests) {
      throw new NotImplementedException();
    }
  }
}