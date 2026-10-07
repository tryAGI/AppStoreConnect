
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsAppAssetLibraryImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsAppAssetLibraryImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsAppAssetLibraryImageDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsAppAssetLibraryImageDataType.AppAssetLibraryImages => "appAssetLibraryImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsAppAssetLibraryImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryImages" => ReviewSubmissionItemRelationshipsAppAssetLibraryImageDataType.AppAssetLibraryImages,
                _ => null,
            };
        }
    }
}