
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmProviders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmProviderType value)
        {
            return value switch
            {
                ScmProviderType.ScmProviders => "scmProviders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmProviderType? ToEnum(string value)
        {
            return value switch
            {
                "scmProviders" => ScmProviderType.ScmProviders,
                _ => null,
            };
        }
    }
}