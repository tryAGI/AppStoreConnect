
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsPreReleaseVersionsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        PreReleaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsPreReleaseVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsPreReleaseVersionsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsPreReleaseVersionsDataItemType.PreReleaseVersions => "preReleaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsPreReleaseVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "preReleaseVersions" => AppRelationshipsPreReleaseVersionsDataItemType.PreReleaseVersions,
                _ => null,
            };
        }
    }
}