using Godot;

namespace GoDoTest.Matchers {
  public static class Should {
    public static void ShouldBe<T>(this T actual, T expected) {
      var type = typeof(T);
      if (!type.IsPrimitive && typeof(T) == typeof(IMatcher)) {
        GD.Print("InvokeMatcher");
      } else {
        GD.Print("Uwu");
      }
    }

    private static void InvokeMatcher<T>(T value, IMatcher matcher) { }

    public static void ShouldMatch<T>(this T expected, IMatcher actual) { }
  }

  public interface IMatcher { }
}