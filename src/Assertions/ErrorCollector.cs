using System;
using System.Collections.Generic;
using System.Linq;
using GoDoTest.Ops;
using Clue = System.Func<string>;

namespace GoDoTest.Assertions {
  public abstract class ErrorCollector {
    /// <summary>
    ///   Returns the current clue context.
    ///   That is all the clues nested to this point.
    /// </summary>
    public static readonly List<Clue> ClueContext = new List<Clue>();

    public static void CollectOrThrow(Exception error) {
      throw new NotImplementedException();
    }

    public static string ClueContextAsString() {
      return ClueContext.Let(it 
        => it.Count == 0 ? "" : it.Aggregate("", (current, func) => current + $"{func()}\n"));
    }
  }

  public class BasicErrorCollector : ErrorCollector { }
}