
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem
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
    public static class AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem value)
        {
            return value switch
            {
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Animation => "ANIMATION",
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Battery => "BATTERY",
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Disk => "DISK",
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Hang => "HANG",
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Launch => "LAUNCH",
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Memory => "MEMORY",
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Storage => "STORAGE",
                AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Termination => "TERMINATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "ANIMATION" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Animation,
                "BATTERY" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Battery,
                "DISK" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Disk,
                "HANG" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Hang,
                "LAUNCH" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Launch,
                "MEMORY" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Memory,
                "STORAGE" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Storage,
                "TERMINATION" => AppsPerfPowerMetricsGetToManyRelatedFilterMetricTypeItem.Termination,
                _ => null,
            };
        }
    }
}