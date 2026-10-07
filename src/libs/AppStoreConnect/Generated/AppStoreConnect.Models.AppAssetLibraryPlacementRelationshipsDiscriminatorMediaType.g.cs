
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementRelationshipsDiscriminatorMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType.Image => "IMAGE",
                AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType? ToEnum(string value)
        {
            return value switch
            {
                "IMAGE" => AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType.Image,
                "VIDEO" => AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType.Video,
                _ => null,
            };
        }
    }
}