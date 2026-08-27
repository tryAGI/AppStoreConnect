
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetAppPreviewsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetAppPreviewsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetAppPreviewsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                AppPreviewSetAppPreviewsLinkagesRequestDataItemType.AppPreviews => "appPreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetAppPreviewsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviews" => AppPreviewSetAppPreviewsLinkagesRequestDataItemType.AppPreviews,
                _ => null,
            };
        }
    }
}