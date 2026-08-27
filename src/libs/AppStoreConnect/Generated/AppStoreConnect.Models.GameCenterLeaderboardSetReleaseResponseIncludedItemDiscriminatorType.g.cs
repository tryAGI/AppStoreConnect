
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetReleaseResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}