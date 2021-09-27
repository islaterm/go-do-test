using Godot;
using GoDoTest.Core.Spec;
using GoDoTest.Core.Spec.Scopes;
using GoDoTest.Matchers;
using static GoDoTest.Core.Spec.Scopes.FunSpecRootContext;
using static GoDoTest.Matchers.StringMatcher;

namespace GoDoTest.godot {
  public class Runner : TestRunner {
    /// <summary>
    ///   Called when the node enters the scene tree for the first time.
    /// </summary>
    public override void _Ready() {
      var _ = new FunSpec(() => {
        const string name = "Sam";
        Test("length should return size of string", () => name.ShouldBe("Sam"));
      });
      base._Ready();
    }
  }

  public class TestRunner : Node {
    public override void _Ready() {
      foreach (var test in AbstractRootContext.Registration) {
        test.Value();
      }
    }
  }
}