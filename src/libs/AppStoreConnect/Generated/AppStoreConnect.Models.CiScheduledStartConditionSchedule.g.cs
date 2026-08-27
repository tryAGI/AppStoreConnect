
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiScheduledStartConditionSchedule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleFrequencyJsonConverter))]
        public global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency? Frequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>? Days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minute")]
        public int? Minute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiScheduledStartConditionSchedule" /> class.
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="days"></param>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiScheduledStartConditionSchedule(
            global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency? frequency,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>? days,
            int? hour,
            int? minute,
            string? timezone)
        {
            this.Frequency = frequency;
            this.Days = days;
            this.Hour = hour;
            this.Minute = minute;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiScheduledStartConditionSchedule" /> class.
        /// </summary>
        public CiScheduledStartConditionSchedule()
        {
        }

    }
}