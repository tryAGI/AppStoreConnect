
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionExperimentAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trafficProportion")]
        public int? TrafficProportion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentAttributesStateJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionExperimentAttributesState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewRequired")]
        public bool? ReviewRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="trafficProportion"></param>
        /// <param name="state"></param>
        /// <param name="reviewRequired"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentAttributes(
            string? name,
            int? trafficProportion,
            global::AppStoreConnect.AppStoreVersionExperimentAttributesState? state,
            bool? reviewRequired,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate)
        {
            this.Name = name;
            this.TrafficProportion = trafficProportion;
            this.State = state;
            this.ReviewRequired = reviewRequired;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentAttributes" /> class.
        /// </summary>
        public AppStoreVersionExperimentAttributes()
        {
        }

    }
}