
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryVideos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryVideos" => AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType.AppAssetLibraryVideos,
                _ => null,
            };
        }
    }
}