
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsAppAssetLibraryVideoDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryVideos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsAppAssetLibraryVideoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsAppAssetLibraryVideoDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsAppAssetLibraryVideoDataType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsAppAssetLibraryVideoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryVideos" => ReviewSubmissionItemRelationshipsAppAssetLibraryVideoDataType.AppAssetLibraryVideos,
                _ => null,
            };
        }
    }
}