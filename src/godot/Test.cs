using Godot;
using GoDoTest.Scenes;
using static GoDoTest.Core.Attributes;

namespace GoDoTest.godot {
  public class Test : TestRunner {
    // Called when the node enters the scene tree for the first time.
    public override void _Ready() {
      
    }

    [Test]
    void Test1() {
      
    }
  }

  public class TestRunner : Node { }
}