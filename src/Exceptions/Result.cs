using System;

namespace GoDoTest.Exceptions {
  public class Result<T> {
    /// <summary>
    ///   A failure marker.
    /// </summary>
    internal class Failure {
      private readonly Exception _exception;

      private Failure(Exception exception) => _exception = exception;

      public override bool Equals(object other) => other is Failure && _exception == ((Failure) other)._exception;

      protected bool Equals(Failure other) => Equals(_exception, other._exception);
      public override int GetHashCode() => _exception != null ? _exception.GetHashCode() : 0;

      public override string ToString() => $"Failure({_exception})";
    }
  }
}