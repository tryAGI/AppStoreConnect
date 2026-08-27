
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PerfPowerMetricAttributesMetricType
    {
        /// <summary>
        ///
        /// </summary>
        Animation,
        /// <summary>
        ///
        /// </summary>
        Battery,
        /// <summary>
        ///
        /// </summary>
        Disk,
        /// <summary>
        ///
        /// </summary>
        Hang,
        /// <summary>
        ///
        /// </summary>
        Launch,
        /// <summary>
        ///
        /// </summary>
        Memory,
        /// <summary>
        ///
        /// </summary>
        Storage,
        /// <summary>
        ///
        /// </summary>
        Termination,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PerfPowerMetricAttributesMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerfPowerMetricAttributesMetricType value)
        {
            return value switch
            {
                PerfPowerMetricAttributesMetricType.Animation => "ANIMATION",
                PerfPowerMetricAttributesMetricType.Battery => "BATTERY",
                PerfPowerMetricAttributesMetricType.Disk => "DISK",
                PerfPowerMetricAttributesMetricType.Hang => "HANG",
                PerfPowerMetricAttributesMetricType.Launch => "LAUNCH",
                PerfPowerMetricAttributesMetricType.Memory => "MEMORY",
                PerfPowerMetricAttributesMetricType.Storage => "STORAGE",
                PerfPowerMetricAttributesMetricType.Termination => "TERMINATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerfPowerMetricAttributesMetricType? ToEnum(string value)
        {
            return value switch
            {
                "ANIMATION" => PerfPowerMetricAttributesMetricType.Animation,
                "BATTERY" => PerfPowerMetricAttributesMetricType.Battery,
                "DISK" => PerfPowerMetricAttributesMetricType.Disk,
                "HANG" => PerfPowerMetricAttributesMetricType.Hang,
                "LAUNCH" => PerfPowerMetricAttributesMetricType.Launch,
                "MEMORY" => PerfPowerMetricAttributesMetricType.Memory,
                "STORAGE" => PerfPowerMetricAttributesMetricType.Storage,
                "TERMINATION" => PerfPowerMetricAttributesMetricType.Termination,
                _ => null,
            };
        }
    }
}