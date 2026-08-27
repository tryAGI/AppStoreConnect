
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviewSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppPreviewsGetInstanceIncludeItem.AppPreviewSet => "appPreviewSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSet" => AppPreviewsGetInstanceIncludeItem.AppPreviewSet,
                _ => null,
            };
        }
    }
}