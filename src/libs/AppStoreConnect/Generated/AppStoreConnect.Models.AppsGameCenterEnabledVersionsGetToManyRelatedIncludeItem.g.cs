
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        CompatibleVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItem.App => "app",
                AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItem.CompatibleVersions => "compatibleVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItem.App,
                "compatibleVersions" => AppsGameCenterEnabledVersionsGetToManyRelatedIncludeItem.CompatibleVersions,
                _ => null,
            };
        }
    }
}