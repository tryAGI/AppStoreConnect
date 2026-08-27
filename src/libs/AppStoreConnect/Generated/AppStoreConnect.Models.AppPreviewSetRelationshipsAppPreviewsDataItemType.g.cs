
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetRelationshipsAppPreviewsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetRelationshipsAppPreviewsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetRelationshipsAppPreviewsDataItemType value)
        {
            return value switch
            {
                AppPreviewSetRelationshipsAppPreviewsDataItemType.AppPreviews => "appPreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetRelationshipsAppPreviewsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviews" => AppPreviewSetRelationshipsAppPreviewsDataItemType.AppPreviews,
                _ => null,
            };
        }
    }
}