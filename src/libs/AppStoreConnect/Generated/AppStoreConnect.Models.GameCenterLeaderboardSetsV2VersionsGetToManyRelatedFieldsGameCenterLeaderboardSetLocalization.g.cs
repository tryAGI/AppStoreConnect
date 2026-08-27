
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Image => "image",
                GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale => "locale",
                GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name => "name",
                GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Image,
                "locale" => GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Locale,
                "name" => GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Name,
                "version" => GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization.Version,
                _ => null,
            };
        }
    }
}