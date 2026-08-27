
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventUpdateRequestDataType value)
        {
            return value switch
            {
                AppEventUpdateRequestDataType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => AppEventUpdateRequestDataType.AppEvents,
                _ => null,
            };
        }
    }
}