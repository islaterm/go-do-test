using System;
using System.Linq;
using GoDoTest.Core.Config;
using GoDoTest.Core.Extensions;
using GoDoTest.Ops;
using GoDoTest.Utils;

namespace GoDoTest.Engine.Dispatchers {
  public static class Factories {
    public static ICoroutineDispatcherFactory CoroutineDispatcherFactory() {
      return Configuration.Instance.Extensions()
        .Select(x => (object) x)
        .FilterIsInstance<ICoroutineDispatcherFactoryExtension>()
        .FirstOrNone()
        .Map(it => it.Factory())
        .GetOrElse(DefaultCoroutineDispatcherFactory);
    }

    private static ExecutorCoroutineDispatcherFactory DefaultCoroutineDispatcherFactory() {
      throw new NotImplementedException();
    }

    private static ICoroutineDispatcherFactory MakeFactory(ICoroutineDispatcherFactoryExtension extension) {
      return extension.Factory();
    }
  }
}