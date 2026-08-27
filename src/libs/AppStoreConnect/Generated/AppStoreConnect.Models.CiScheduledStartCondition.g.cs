
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiScheduledStartCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::AppStoreConnect.CiBranchPatterns? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::AppStoreConnect.CiScheduledStartConditionSchedule? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiScheduledStartCondition" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="schedule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiScheduledStartCondition(
            global::AppStoreConnect.CiBranchPatterns? source,
            global::AppStoreConnect.CiScheduledStartConditionSchedule? schedule)
        {
            this.Source = source;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiScheduledStartCondition" /> class.
        /// </summary>
        public CiScheduledStartCondition()
        {
        }

    }
}