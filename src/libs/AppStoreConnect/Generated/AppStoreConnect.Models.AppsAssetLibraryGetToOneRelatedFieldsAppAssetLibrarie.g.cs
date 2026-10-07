
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarie
    {
        /// <summary>
        ///
        /// </summary>
        Images,
        /// <summary>
        ///
        /// </summary>
        Videos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarie value)
        {
            return value switch
            {
                AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarie.Images => "images",
                AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarie.Videos => "videos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarie? ToEnum(string value)
        {
            return value switch
            {
                "images" => AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarie.Images,
                "videos" => AppsAssetLibraryGetToOneRelatedFieldsAppAssetLibrarie.Videos,
                _ => null,
            };
        }
    }
}