
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem
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
    public static class BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem value)
        {
            return value switch
            {
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Animation => "ANIMATION",
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Battery => "BATTERY",
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Disk => "DISK",
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Hang => "HANG",
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Launch => "LAUNCH",
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Memory => "MEMORY",
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Storage => "STORAGE",
                BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Termination => "TERMINATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "ANIMATION" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Animation,
                "BATTERY" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Battery,
                "DISK" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Disk,
                "HANG" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Hang,
                "LAUNCH" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Launch,
                "MEMORY" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Memory,
                "STORAGE" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Storage,
                "TERMINATION" => BuildsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Termination,
                _ => null,
            };
        }
    }
}