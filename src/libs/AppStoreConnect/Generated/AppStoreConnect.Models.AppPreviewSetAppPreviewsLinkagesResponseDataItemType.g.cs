
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetAppPreviewsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetAppPreviewsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetAppPreviewsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPreviewSetAppPreviewsLinkagesResponseDataItemType.AppPreviews => "appPreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetAppPreviewsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviews" => AppPreviewSetAppPreviewsLinkagesResponseDataItemType.AppPreviews,
                _ => null,
            };
        }
    }
}