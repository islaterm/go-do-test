using System;
using System.Collections.Generic;
using Godot;
using GoDoTest.Core;
using GoDoTest.Core.Spec;
using GoDoTest.Matchers;
using static GoDoTest.Core.Spec.Scopes.FunSpecRootContext;
using static GoDoTest.Matchers.StringMatcher;

namespace GoDoTest.godot {
  public class Runner : TestRunner {
    // Called when the node enters the scene tree for the first time.
    public override void _Ready() {
      var _ = new FunSpec(() => {
        Test("length should return size of string", () => "hello".Length.ShouldBe(5));
        Test("startsWith should test for a prefix", () => "world".ShouldMatch(StartWith("wor")));
      });
      base._Ready();
    }

    private void RegisterTest(Action test) {
      Tests.Add(test);
    }

    private void Test1() {
      Assert.Equal(true, false);
    }

    public class ExSpec : FunSpec {
      public ExSpec(Action test) : base(test) { }
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