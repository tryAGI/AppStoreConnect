
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionPhasedReleaseAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phasedReleaseState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PhasedReleaseStateJsonConverter))]
        public global::AppStoreConnect.PhasedReleaseState? PhasedReleaseState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPauseDuration")]
        public int? TotalPauseDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentDayNumber")]
        public int? CurrentDayNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPhasedReleaseAttributes" /> class.
        /// </summary>
        /// <param name="phasedReleaseState"></param>
        /// <param name="startDate"></param>
        /// <param name="totalPauseDuration"></param>
        /// <param name="currentDayNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionPhasedReleaseAttributes(
            global::AppStoreConnect.PhasedReleaseState? phasedReleaseState,
            global::System.DateTime? startDate,
            int? totalPauseDuration,
            int? currentDayNumber)
        {
            this.PhasedReleaseState = phasedReleaseState;
            this.StartDate = startDate;
            this.TotalPauseDuration = totalPauseDuration;
            this.CurrentDayNumber = currentDayNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPhasedReleaseAttributes" /> class.
        /// </summary>
        public AppStoreVersionPhasedReleaseAttributes()
        {
        }

    }
}