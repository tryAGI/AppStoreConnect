
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAppVersionsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                GameCenterAppVersionsResponseIncludedItemDiscriminatorType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => GameCenterAppVersionsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "gameCenterAppVersions" => GameCenterAppVersionsResponseIncludedItemDiscriminatorType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}