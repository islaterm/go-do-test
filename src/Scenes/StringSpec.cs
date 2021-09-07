using System;

namespace GoDoTest.Scenes {
  public class StringSpec {
    public StringSpec(Action body) => body.Invoke();
  }
}