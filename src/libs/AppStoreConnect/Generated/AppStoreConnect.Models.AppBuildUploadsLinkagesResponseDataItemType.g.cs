
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppBuildUploadsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBuildUploadsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBuildUploadsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppBuildUploadsLinkagesResponseDataItemType.BuildUploads => "buildUploads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBuildUploadsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploads" => AppBuildUploadsLinkagesResponseDataItemType.BuildUploads,
                _ => null,
            };
        }
    }
}