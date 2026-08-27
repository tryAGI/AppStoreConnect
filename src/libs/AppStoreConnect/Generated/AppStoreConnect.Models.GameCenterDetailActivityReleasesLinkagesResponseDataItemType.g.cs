
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailActivityReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailActivityReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailActivityReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailActivityReleasesLinkagesResponseDataItemType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailActivityReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersionReleases" => GameCenterDetailActivityReleasesLinkagesResponseDataItemType.GameCenterActivityVersionReleases,
                _ => null,
            };
        }
    }
}