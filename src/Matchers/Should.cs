namespace GoDoTest.Matchers {
  public static class Should {
    public static void ShouldBe<T>(this T actual, T expected) {
      
    }
    
    public static void ShouldMatch<T>(this T t, IMatcher<T> matcher) {}
  }

  public interface IMatcher<T> { }
}