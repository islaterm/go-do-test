using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace GoDoTest.Core.Spec.Scopes {
  public interface IRootContext {}
  public abstract class AbstractRootContext : IRootContext {
    public static IDictionary<string, Action> Registration = new ConcurrentDictionary<string, Action>();
  }
}