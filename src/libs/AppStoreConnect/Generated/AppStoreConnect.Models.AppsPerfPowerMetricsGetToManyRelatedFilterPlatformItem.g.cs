
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsPerfPowerMetricsGetToManyRelatedFilterPlatformItem
    {
        /// <summary>
        ///
        /// </summary>
        Ios,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsPerfPowerMetricsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsPerfPowerMetricsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                AppsPerfPowerMetricsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsPerfPowerMetricsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsPerfPowerMetricsGetToManyRelatedFilterPlatformItem.Ios,
                _ => null,
            };
        }
    }
}