
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewUpdateRequestDataType value)
        {
            return value switch
            {
                AppPreviewUpdateRequestDataType.AppPreviews => "appPreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviews" => AppPreviewUpdateRequestDataType.AppPreviews,
                _ => null,
            };
        }
    }
}