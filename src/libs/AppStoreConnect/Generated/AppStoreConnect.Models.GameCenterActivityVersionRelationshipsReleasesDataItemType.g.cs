
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionRelationshipsReleasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionRelationshipsReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionRelationshipsReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterActivityVersionRelationshipsReleasesDataItemType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionRelationshipsReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersionReleases" => GameCenterActivityVersionRelationshipsReleasesDataItemType.GameCenterActivityVersionReleases,
                _ => null,
            };
        }
    }
}