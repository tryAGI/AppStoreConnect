
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppTagUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppTags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTagUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppTagUpdateRequestDataType value)
        {
            return value switch
            {
                AppTagUpdateRequestDataType.AppTags => "appTags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppTagUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appTags" => AppTagUpdateRequestDataType.AppTags,
                _ => null,
            };
        }
    }
}