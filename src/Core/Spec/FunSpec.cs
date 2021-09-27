using System;
using GoDoTest.Core.Spec.Scopes;

namespace GoDoTest.Core.Spec {
  public class FunSpec: FunSpecRootContext {
    private FunSpecRootContext _context = FunSpecRootContext.Instance;
    public FunSpec(Action body) {
      body();
    }
  }
}