
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}