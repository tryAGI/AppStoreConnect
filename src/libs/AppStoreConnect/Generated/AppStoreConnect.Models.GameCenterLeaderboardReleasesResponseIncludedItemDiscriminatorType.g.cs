
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterLeaderboards" => GameCenterLeaderboardReleasesResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}