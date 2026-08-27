
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetails,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroups,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions,
                "gameCenterDetails" => GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboards" => GameCenterChallengesResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}