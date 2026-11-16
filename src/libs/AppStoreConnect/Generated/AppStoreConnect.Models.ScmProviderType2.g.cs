
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmProviderType2
    {
        /// <summary>
        ///
        /// </summary>
        ScmProviders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmProviderType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProviderType2 value)
        {
            return value switch
            {
                ScmProviderType2.ScmProviders => "scmProviders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProviderType2? ToEnum(string value)
        {
            return value switch
            {
                "scmProviders" => ScmProviderType2.ScmProviders,
                _ => null,
            };
        }
    }
}