
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem
    {
        /// <summary>
        /// 
        /// </summary>
        Ios,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => BuildsPerfPowerMetricsGetToManyRelatedFilterPlatformItem.Ios,
                _ => null,
            };
        }
    }
}