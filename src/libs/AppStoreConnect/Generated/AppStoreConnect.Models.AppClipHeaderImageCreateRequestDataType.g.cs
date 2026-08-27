
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipHeaderImageCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipHeaderImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipHeaderImageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipHeaderImageCreateRequestDataType value)
        {
            return value switch
            {
                AppClipHeaderImageCreateRequestDataType.AppClipHeaderImages => "appClipHeaderImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipHeaderImageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipHeaderImages" => AppClipHeaderImageCreateRequestDataType.AppClipHeaderImages,
                _ => null,
            };
        }
    }
}