using Godot;
using GoDoTest.Core.Spec;
using GoDoTest.Engine.Launchers;
using GoDoTest.Matchers;
using GoDoTest.Ops;
using static GoDoTest.Core.Spec.Scopes.FunSpecRootContext;
using static GoDoTest.Matchers.StringMatcher;

namespace GoDoTest.godot {
  public class Runner : TestRunner {
    /// <summary>
    ///   Called when the node enters the scene tree for the first time.
    /// </summary>
    [MustBeDocumented]
    public override void _Ready() {
      Spec = new FunSpec(() => {
        Test("length should return size of string", () => "hello".Length.ShouldBe(5));
        Test("startsWith should test for a prefix", () => "world".ShouldMatch(StartWith("woa")));
      });
      base._Ready();
    }
  }

  [MustBeDocumented]
  public class TestRunner : Node {
    protected ISpec Spec;


    [MustBeDocumented]
    public override void _Ready() {
      TestLauncherFactory.TestLauncher(Spec);
    }
  }
}