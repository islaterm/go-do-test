using System;

namespace GoDoTest.Core.Spec.Scopes {
  public class FunSpecRootContext : AbstractRootContext {
    protected FunSpecRootContext() { }
    protected static FunSpecRootContext Instance { get; } = new FunSpecRootContext();

    public static void Test(string name, Action test) {
      Registration.Add(name, test);
    }
  }
}