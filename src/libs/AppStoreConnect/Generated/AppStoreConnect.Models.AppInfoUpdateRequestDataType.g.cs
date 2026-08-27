
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoUpdateRequestDataType value)
        {
            return value switch
            {
                AppInfoUpdateRequestDataType.AppInfos => "appInfos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appInfos" => AppInfoUpdateRequestDataType.AppInfos,
                _ => null,
            };
        }
    }
}