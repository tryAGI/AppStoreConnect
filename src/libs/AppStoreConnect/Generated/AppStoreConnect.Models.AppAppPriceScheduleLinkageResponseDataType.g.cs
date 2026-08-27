
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAppPriceScheduleLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPriceSchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppPriceScheduleLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppPriceScheduleLinkageResponseDataType value)
        {
            return value switch
            {
                AppAppPriceScheduleLinkageResponseDataType.AppPriceSchedules => "appPriceSchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppPriceScheduleLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPriceSchedules" => AppAppPriceScheduleLinkageResponseDataType.AppPriceSchedules,
                _ => null,
            };
        }
    }
}