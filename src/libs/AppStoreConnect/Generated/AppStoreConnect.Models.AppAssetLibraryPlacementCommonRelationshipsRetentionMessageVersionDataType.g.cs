
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCommonRelationshipsRetentionMessageVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCommonRelationshipsRetentionMessageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCommonRelationshipsRetentionMessageVersionDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCommonRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions => "retentionMessageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCommonRelationshipsRetentionMessageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => AppAssetLibraryPlacementCommonRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions,
                _ => null,
            };
        }
    }
}