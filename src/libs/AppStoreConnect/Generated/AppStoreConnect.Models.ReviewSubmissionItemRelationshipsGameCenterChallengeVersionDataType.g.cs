
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => ReviewSubmissionItemRelationshipsGameCenterChallengeVersionDataType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}