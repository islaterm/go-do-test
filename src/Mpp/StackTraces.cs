using System;

namespace GoDoTest.Mpp {
  public static class StackTraces {
    public static T CleanStackTrace<T>(T exception) where T : Exception => exception;
  }
}