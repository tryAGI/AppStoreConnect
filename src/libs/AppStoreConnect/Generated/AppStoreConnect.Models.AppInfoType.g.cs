
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoType value)
        {
            return value switch
            {
                AppInfoType.AppInfos => "appInfos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoType? ToEnum(string value)
        {
            return value switch
            {
                "appInfos" => AppInfoType.AppInfos,
                _ => null,
            };
        }
    }
}