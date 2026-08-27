
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiScheduledStartConditionScheduleFrequency
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Hourly,
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiScheduledStartConditionScheduleFrequencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiScheduledStartConditionScheduleFrequency value)
        {
            return value switch
            {
                CiScheduledStartConditionScheduleFrequency.Daily => "DAILY",
                CiScheduledStartConditionScheduleFrequency.Hourly => "HOURLY",
                CiScheduledStartConditionScheduleFrequency.Weekly => "WEEKLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiScheduledStartConditionScheduleFrequency? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => CiScheduledStartConditionScheduleFrequency.Daily,
                "HOURLY" => CiScheduledStartConditionScheduleFrequency.Hourly,
                "WEEKLY" => CiScheduledStartConditionScheduleFrequency.Weekly,
                _ => null,
            };
        }
    }
}