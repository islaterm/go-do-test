using System;
using GoDoTest.Engine.Dispatchers;

namespace GoDoTest.Core.Extensions {
  /// <summary>
  /// An extension point that can be used to return a custom <see cref="ICoroutineDispatcherFactory"/>.
  /// </summary>
  public interface ICoroutineDispatcherFactoryExtension {
    ICoroutineDispatcherFactory Factory();
  }
}