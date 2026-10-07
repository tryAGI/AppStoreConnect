
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementCreateRequestDataRelationshipsImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementCreateRequestDataRelationshipsImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementCreateRequestDataRelationshipsImageDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementCreateRequestDataRelationshipsImageDataType.AppAssetLibraryImages => "appAssetLibraryImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementCreateRequestDataRelationshipsImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryImages" => AppAssetLibraryPlacementCreateRequestDataRelationshipsImageDataType.AppAssetLibraryImages,
                _ => null,
            };
        }
    }
}