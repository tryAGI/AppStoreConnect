
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        ChallengeIds,
        /// <summary>
        ///
        /// </summary>
        Context,
        /// <summary>
        ///
        /// </summary>
        Player,
        /// <summary>
        ///
        /// </summary>
        PreReleased,
        /// <summary>
        ///
        /// </summary>
        Rank,
        /// <summary>
        ///
        /// </summary>
        Score,
        /// <summary>
        ///
        /// </summary>
        SubmittedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModerationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Blocked => "blocked",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.ChallengeIds => "challengeIds",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Context => "context",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Player => "player",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.PreReleased => "preReleased",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Rank => "rank",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Score => "score",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.SubmittedDate => "submittedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Blocked,
                "challengeIds" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.ChallengeIds,
                "context" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Context,
                "player" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Player,
                "preReleased" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.PreReleased,
                "rank" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Rank,
                "score" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.Score,
                "submittedDate" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration.SubmittedDate,
                _ => null,
            };
        }
    }
}