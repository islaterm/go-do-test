namespace GoDoTest.Assertions {
  public static class AssertionCounter {
    private static int Counter { get; set; }

    /// <summary>
    ///   Increases the counter of assertions made in this context.
    /// </summary>
    public static void Inc() => Counter++;
  }
}