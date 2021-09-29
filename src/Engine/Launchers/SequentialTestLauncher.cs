using System;
using System.Collections.Generic;
using GoDoTest.Core.Test;
using GoDoTest.Engine.Dispatchers;

namespace GoDoTest.Engine.Launchers {
  /// <summary>
  ///   This implementation of <see cref="ITestLauncher" /> will launch all tests consecutively.
  /// </summary>
  public class SequentialTestLauncher : ITestLauncher {
    /// <param name="factory">A <see cref="ICoroutineDispatcherFactory" /> used to allocate dispatchers for tests.</param>
    public SequentialTestLauncher(ICoroutineDispatcherFactory factory) { }

    public void Launch(Action<TestCase> run, List<TestCase> tests) {
      throw new NotImplementedException();
    }
  }
}