
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationV2CreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationV2CreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationV2CreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationV2CreateRequestDataRelationshipsVersionDataType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationV2CreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardVersions" => GameCenterLeaderboardLocalizationV2CreateRequestDataRelationshipsVersionDataType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}