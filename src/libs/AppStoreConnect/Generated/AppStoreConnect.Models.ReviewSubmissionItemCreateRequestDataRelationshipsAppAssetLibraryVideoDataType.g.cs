
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryVideos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryVideos" => ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType.AppAssetLibraryVideos,
                _ => null,
            };
        }
    }
}