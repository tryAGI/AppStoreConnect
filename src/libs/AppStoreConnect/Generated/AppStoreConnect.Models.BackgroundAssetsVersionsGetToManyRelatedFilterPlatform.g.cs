
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFilterPlatform
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFilterPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFilterPlatform value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.Ios => "IOS",
                BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.MacOs => "MAC_OS",
                BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.TvOs => "TV_OS",
                BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFilterPlatform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.Ios,
                "MAC_OS" => BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.MacOs,
                "TV_OS" => BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.TvOs,
                "VISION_OS" => BackgroundAssetsVersionsGetToManyRelatedFilterPlatform.VisionOs,
                _ => null,
            };
        }
    }
}