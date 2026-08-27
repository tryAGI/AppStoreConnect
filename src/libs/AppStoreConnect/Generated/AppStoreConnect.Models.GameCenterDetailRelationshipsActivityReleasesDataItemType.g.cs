
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsActivityReleasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsActivityReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsActivityReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsActivityReleasesDataItemType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsActivityReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersionReleases" => GameCenterDetailRelationshipsActivityReleasesDataItemType.GameCenterActivityVersionReleases,
                _ => null,
            };
        }
    }
}