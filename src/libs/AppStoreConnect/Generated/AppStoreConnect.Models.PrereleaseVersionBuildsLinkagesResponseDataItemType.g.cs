
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PrereleaseVersionBuildsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrereleaseVersionBuildsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrereleaseVersionBuildsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                PrereleaseVersionBuildsLinkagesResponseDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrereleaseVersionBuildsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => PrereleaseVersionBuildsLinkagesResponseDataItemType.Builds,
                _ => null,
            };
        }
    }
}