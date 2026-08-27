
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                GameCenterChallengeVersionRelationshipsLocalizationsDataItemType.GameCenterChallengeLocalizations => "gameCenterChallengeLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeLocalizations" => GameCenterChallengeVersionRelationshipsLocalizationsDataItemType.GameCenterChallengeLocalizations,
                _ => null,
            };
        }
    }
}