using System;
using System.Collections.Generic;
using GoDoTest.Ops;

namespace GoDoTest.Utils {
  [MustBeDocumented]
  public static class Options {
    [MustBeDocumented]
    public static Option FirstOrNone<T>(this IEnumerable<T> enumerable) where T : class {
      return enumerable.FirstOrNull().ToOption();
    }

    [MustBeDocumented]
    private static Option ToOption(this object self) {
      return self == null ? (Option) new Option.None() : new Option.Some(self);
    }

    [MustBeDocumented]
    public class Option {
      [MustBeDocumented]
      public Option Map(Func<object, object> func) {
        switch (this) {
          case None _:
            return this;
          case Some _:
            return new Some(func(((Some) this).Value));
          default:
            throw new ArgumentException($"Option should be one of [None, Some], but was {GetType()}");
        }
      }

      [MustBeDocumented]
      public class None : Option { }

      [MustBeDocumented]
      public class Some : Option {

        [MustBeDocumented]
        public Some(object value) {
          Value = value;
        }

        public object Value { get; }
      }
    }
  }
}