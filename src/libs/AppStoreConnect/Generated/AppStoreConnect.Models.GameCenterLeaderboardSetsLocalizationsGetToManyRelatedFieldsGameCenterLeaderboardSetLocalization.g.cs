
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSet,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetImage,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage => "gameCenterLeaderboardSetImage",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSet,
                "gameCenterLeaderboardSetImage" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.GameCenterLeaderboardSetImage,
                "locale" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetsLocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name,
                _ => null,
            };
        }
    }
}