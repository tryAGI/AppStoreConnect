
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem.AppPreviewSet => "appPreviewSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSet" => AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem.AppPreviewSet,
                _ => null,
            };
        }
    }
}