using System;

namespace GoDoTest.Matchers {
  public static class Is {
    public static Func<double, bool> EqualTo(double y, double delta = 1e-10) => x => Math.Abs(x - y) < delta;

    public static Func<object, bool> EqualTo(object y) =>
      throw new NotImplementedException("EqualTo for objects is not defined.");
  }
}