using System;

namespace GoDoTest.Core.Spec.Scopes {
  public class FunSpecRootContext : AbstractRootContext {
    private FunSpecRootContext() { }
    public static FunSpecRootContext Instance { get; } = new FunSpecRootContext();
    public static void Test(string name, Action test) { }
  }
}