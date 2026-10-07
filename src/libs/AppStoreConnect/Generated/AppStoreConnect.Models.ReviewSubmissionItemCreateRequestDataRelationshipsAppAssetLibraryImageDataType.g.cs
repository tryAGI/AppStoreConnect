
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType.AppAssetLibraryImages => "appAssetLibraryImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryImages" => ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType.AppAssetLibraryImages,
                _ => null,
            };
        }
    }
}