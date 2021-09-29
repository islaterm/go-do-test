using System;
using System.Collections.Generic;
using GoDoTest.Core.Spec;
using GoDoTest.Core.Test;

namespace GoDoTest.Engine.Launchers {
  public interface ITestLauncher {
    void Launch(Action<TestCase> run, List<TestCase> tests);
  }

  public abstract class AbstractTestLauncher : ITestLauncher {
    public abstract void Launch(Action<TestCase> run, List<TestCase> tests);

    public static ITestLauncher TestLauncher(ISpec spec) => throw new NotImplementedException();
  }
}