using System;
using Godot;

namespace GoDoTest.Mpp {
  public class Logger {
    public static bool IsLogEnabled = false;

    public void Log(Func<string> f) {
      if (IsLogEnabled) {
        GD.Print(f());
      }
    }
  }
}