
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewCreateRequestDataType value)
        {
            return value switch
            {
                AppPreviewCreateRequestDataType.AppPreviews => "appPreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviews" => AppPreviewCreateRequestDataType.AppPreviews,
                _ => null,
            };
        }
    }
}