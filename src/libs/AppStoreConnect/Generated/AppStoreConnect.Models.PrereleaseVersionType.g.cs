
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PrereleaseVersionType
    {
        /// <summary>
        ///
        /// </summary>
        PreReleaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrereleaseVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrereleaseVersionType value)
        {
            return value switch
            {
                PrereleaseVersionType.PreReleaseVersions => "preReleaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrereleaseVersionType? ToEnum(string value)
        {
            return value switch
            {
                "preReleaseVersions" => PrereleaseVersionType.PreReleaseVersions,
                _ => null,
            };
        }
    }
}