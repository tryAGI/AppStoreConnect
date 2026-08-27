
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionResponseIncludedItemDiscriminatorType
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
    public static class GameCenterAppVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAppVersionResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                GameCenterAppVersionResponseIncludedItemDiscriminatorType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => GameCenterAppVersionResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "gameCenterAppVersions" => GameCenterAppVersionResponseIncludedItemDiscriminatorType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}