
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MetricCategory
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
    public static class MetricCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricCategory value)
        {
            return value switch
            {
                MetricCategory.Animation => "ANIMATION",
                MetricCategory.Battery => "BATTERY",
                MetricCategory.Disk => "DISK",
                MetricCategory.Hang => "HANG",
                MetricCategory.Launch => "LAUNCH",
                MetricCategory.Memory => "MEMORY",
                MetricCategory.Storage => "STORAGE",
                MetricCategory.Termination => "TERMINATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricCategory? ToEnum(string value)
        {
            return value switch
            {
                "ANIMATION" => MetricCategory.Animation,
                "BATTERY" => MetricCategory.Battery,
                "DISK" => MetricCategory.Disk,
                "HANG" => MetricCategory.Hang,
                "LAUNCH" => MetricCategory.Launch,
                "MEMORY" => MetricCategory.Memory,
                "STORAGE" => MetricCategory.Storage,
                "TERMINATION" => MetricCategory.Termination,
                _ => null,
            };
        }
    }
}