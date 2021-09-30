using System;
using System.Collections.Generic;
using GoDoTest.Ops;

namespace GoDoTest.Utils {
  [MustBeDocumented]
  public static class Options {
    [MustBeDocumented]
    public static Option FirstOrNone<T>(this IEnumerable<T> enumerable) where T : class =>
      enumerable.FirstOrNull().ToOption();

    [MustBeDocumented]
    public static Option ToOption(this object self) =>
      self == null ? (Option) new Option.None() : new Option.Some(self);

    [MustBeDocumented]
    public class Option {
      // [MustBeDocumented]
      // [ComingSoon]
      // public Option<T> Map(Func<T> func) {
      //   if (this is None) {
      //     return this;
      //   }
      //
      //   if (this is Some) {
      //     return func(this.Value).Some();
      //   }
      // }
      //
      // public class None : Option<Nothing> {
      //   public Option<TR> Map<TR>(Func<T, TR> func) {
      //     return null;
      //   }
      // }
      [MustBeDocumented]
      public class None : Option { }

      [MustBeDocumented]
      public class Some : Option {
        public Some(object value) => throw new NotImplementedException();
      }
    }
  }
}