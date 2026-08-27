
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem
    {
        /// <summary>
        ///
        /// </summary>
        Ios,
        /// <summary>
        ///
        /// </summary>
        MacOs,
        /// <summary>
        ///
        /// </summary>
        TvOs,
        /// <summary>
        ///
        /// </summary>
        VisionOs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.MacOs => "MAC_OS",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.TvOs => "TV_OS",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.Ios,
                "MAC_OS" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.MacOs,
                "TV_OS" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.TvOs,
                "VISION_OS" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}