
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType.AppStoreVersions,
                _ => null,
            };
        }
    }
}