using System;
using GoDoTest.Core.Spec.Scopes;

namespace GoDoTest.Core.Spec {
  public class FunSpec : FunSpecRootContext, ISpec {
    private FunSpecRootContext _context = Instance;

    public FunSpec(Action body) {
      body();
    }
  }
}