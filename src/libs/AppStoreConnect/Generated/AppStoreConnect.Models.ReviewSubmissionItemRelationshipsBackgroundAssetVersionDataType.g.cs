
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions => "backgroundAssetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetVersions" => ReviewSubmissionItemRelationshipsBackgroundAssetVersionDataType.BackgroundAssetVersions,
                _ => null,
            };
        }
    }
}