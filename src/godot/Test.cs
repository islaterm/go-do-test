using System;
using System.Collections.Generic;
using Godot;
using GoDoTest.Core;

namespace GoDoTest.godot {
  public class Test : TestRunner {
    // Called when the node enters the scene tree for the first time.
    public override void _Ready() {
      RegisterTest(Test1);
      base._Ready();
    }

    private void RegisterTest(Action test) {
      Tests.Add(test);
    }

    private void Test1() {
      Assert.Equal(true, false);
    }
  }

  public class TestRunner : Node {
    protected List<Action> Tests = new List<Action>();

    public override void _Ready() {
      foreach (var test in Tests) {
        test();
      }
    }
  }
}