
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PerfPowerMetricAttributesPlatform
    {
        /// <summary>
        /// 
        /// </summary>
        Ios,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PerfPowerMetricAttributesPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerfPowerMetricAttributesPlatform value)
        {
            return value switch
            {
                PerfPowerMetricAttributesPlatform.Ios => "IOS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerfPowerMetricAttributesPlatform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => PerfPowerMetricAttributesPlatform.Ios,
                _ => null,
            };
        }
    }
}