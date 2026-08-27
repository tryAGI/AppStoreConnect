
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterEnabledVersionsGetToManyRelatedSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        MinusversionString,
        /// <summary>
        /// 
        /// </summary>
        VersionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGameCenterEnabledVersionsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterEnabledVersionsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                AppsGameCenterEnabledVersionsGetToManyRelatedSortItem.MinusversionString => "-versionString",
                AppsGameCenterEnabledVersionsGetToManyRelatedSortItem.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterEnabledVersionsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-versionString" => AppsGameCenterEnabledVersionsGetToManyRelatedSortItem.MinusversionString,
                "versionString" => AppsGameCenterEnabledVersionsGetToManyRelatedSortItem.VersionString,
                _ => null,
            };
        }
    }
}