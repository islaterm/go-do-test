using System;
using System.Collections.Generic;
using System.Linq;
using Clue = System.Func<string>;

namespace GoDoTest.Assertions {
  public abstract class ErrorCollector {
    /// <summary>
    ///   Returns the current clue context.
    ///   That is all the clues nested to this point.
    /// </summary>
    public static readonly List<Clue> ClueContext = new List<Clue>();

    public abstract ErrorCollectionMode CollectionMode { get; }

    public abstract void PushError(Exception error);

    public void CollectOrThrow(Exception error) {
      switch (CollectionMode) {
        case ErrorCollectionMode.Soft:
          PushError(error);
          break;
        case ErrorCollectionMode.Hard:
          throw error;
        default:
          throw new ArgumentOutOfRangeException(nameof(error),
            $"Error collection mode should be Soft or Hard, but was {CollectionMode}");
      }
    }

    public static readonly ErrorCollector ErrorCollectorInstance = new BasicErrorCollector();

    public static string ClueContextAsString() {
      return ClueContext.Let(it
        => it.Count == 0 ? "" : it.Aggregate("", (current, func) => current + $"{func()}\n"));
    }
  }

  public class BasicErrorCollector : ErrorCollector {
    public override ErrorCollectionMode CollectionMode => ErrorCollectionMode.Hard;

    public override void PushError(Exception error) {
      throw new NotImplementedException();
    }
  }

  public enum ErrorCollectionMode {
    Soft,
    Hard
  }
}