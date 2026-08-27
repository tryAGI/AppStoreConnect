
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType value)
        {
            return value switch
            {
                GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType.GameCenterChallengeLocalizations => "gameCenterChallengeLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeLocalizations" => GameCenterChallengeImageCreateRequestDataRelationshipsLocalizationDataType.GameCenterChallengeLocalizations,
                _ => null,
            };
        }
    }
}