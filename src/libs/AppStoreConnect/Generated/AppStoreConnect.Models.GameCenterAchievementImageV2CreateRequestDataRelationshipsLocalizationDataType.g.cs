
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementImageV2CreateRequestDataRelationshipsLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementImageV2CreateRequestDataRelationshipsLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImageV2CreateRequestDataRelationshipsLocalizationDataType value)
        {
            return value switch
            {
                GameCenterAchievementImageV2CreateRequestDataRelationshipsLocalizationDataType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImageV2CreateRequestDataRelationshipsLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementImageV2CreateRequestDataRelationshipsLocalizationDataType.GameCenterAchievementLocalizations,
                _ => null,
            };
        }
    }
}