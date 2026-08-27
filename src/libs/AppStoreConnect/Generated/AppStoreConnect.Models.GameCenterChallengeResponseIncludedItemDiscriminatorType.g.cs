
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeResponseIncludedItemDiscriminatorType
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
    public static class GameCenterChallengeResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions,
                "gameCenterDetails" => GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboards" => GameCenterChallengeResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}