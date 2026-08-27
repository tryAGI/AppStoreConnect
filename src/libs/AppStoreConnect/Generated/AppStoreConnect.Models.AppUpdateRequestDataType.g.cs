
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppUpdateRequestDataType value)
        {
            return value switch
            {
                AppUpdateRequestDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppUpdateRequestDataType.Apps,
                _ => null,
            };
        }
    }
}