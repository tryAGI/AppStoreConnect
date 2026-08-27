
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => GameCenterDetailChallengesMinimumPlatformVersionsLinkagesRequestDataItemType.AppStoreVersions,
                _ => null,
            };
        }
    }
}