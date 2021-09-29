namespace GoDoTest.Core.Config {
  /// <summary>
  ///   This class defines project wide settings that are used when executing tests.
  ///   Some settings here are fallback values. That is, a setting specified in a Spec or Test
  ///   will override the value here.
  /// </summary>
  public class Configuration {
    public const int Sequential = 1;

    private Configuration() { }

    /// <summary>
    ///   The global configuration singleton.
    /// </summary>
    public static Configuration Instance { get; } = new Configuration();
  }
}