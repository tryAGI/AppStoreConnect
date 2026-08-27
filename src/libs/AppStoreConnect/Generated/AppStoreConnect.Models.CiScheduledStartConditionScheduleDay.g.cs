
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiScheduledStartConditionScheduleDay
    {
        /// <summary>
        /// 
        /// </summary>
        Friday,
        /// <summary>
        /// 
        /// </summary>
        Monday,
        /// <summary>
        /// 
        /// </summary>
        Saturday,
        /// <summary>
        /// 
        /// </summary>
        Sunday,
        /// <summary>
        /// 
        /// </summary>
        Thursday,
        /// <summary>
        /// 
        /// </summary>
        Tuesday,
        /// <summary>
        /// 
        /// </summary>
        Wednesday,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiScheduledStartConditionScheduleDayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiScheduledStartConditionScheduleDay value)
        {
            return value switch
            {
                CiScheduledStartConditionScheduleDay.Friday => "FRIDAY",
                CiScheduledStartConditionScheduleDay.Monday => "MONDAY",
                CiScheduledStartConditionScheduleDay.Saturday => "SATURDAY",
                CiScheduledStartConditionScheduleDay.Sunday => "SUNDAY",
                CiScheduledStartConditionScheduleDay.Thursday => "THURSDAY",
                CiScheduledStartConditionScheduleDay.Tuesday => "TUESDAY",
                CiScheduledStartConditionScheduleDay.Wednesday => "WEDNESDAY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiScheduledStartConditionScheduleDay? ToEnum(string value)
        {
            return value switch
            {
                "FRIDAY" => CiScheduledStartConditionScheduleDay.Friday,
                "MONDAY" => CiScheduledStartConditionScheduleDay.Monday,
                "SATURDAY" => CiScheduledStartConditionScheduleDay.Saturday,
                "SUNDAY" => CiScheduledStartConditionScheduleDay.Sunday,
                "THURSDAY" => CiScheduledStartConditionScheduleDay.Thursday,
                "TUESDAY" => CiScheduledStartConditionScheduleDay.Tuesday,
                "WEDNESDAY" => CiScheduledStartConditionScheduleDay.Wednesday,
                _ => null,
            };
        }
    }
}