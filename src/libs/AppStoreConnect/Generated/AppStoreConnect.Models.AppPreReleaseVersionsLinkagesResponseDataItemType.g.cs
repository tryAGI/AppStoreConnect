
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreReleaseVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        PreReleaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreReleaseVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreReleaseVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPreReleaseVersionsLinkagesResponseDataItemType.PreReleaseVersions => "preReleaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreReleaseVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "preReleaseVersions" => AppPreReleaseVersionsLinkagesResponseDataItemType.PreReleaseVersions,
                _ => null,
            };
        }
    }
}