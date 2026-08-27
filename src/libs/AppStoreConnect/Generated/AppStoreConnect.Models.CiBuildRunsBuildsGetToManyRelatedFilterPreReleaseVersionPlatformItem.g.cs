
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem
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
    public static class CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.Ios => "IOS",
                CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.MacOs => "MAC_OS",
                CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.TvOs => "TV_OS",
                CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.Ios,
                "MAC_OS" => CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.MacOs,
                "TV_OS" => CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.TvOs,
                "VISION_OS" => CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}