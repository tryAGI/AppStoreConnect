
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}