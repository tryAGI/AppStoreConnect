
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionExperimentUpdateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("started")]
        public bool? Started { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="trafficProportion"></param>
        /// <param name="started"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentUpdateRequestDataAttributes(
            string? name,
            int? trafficProportion,
            bool? started)
        {
            this.Name = name;
            this.TrafficProportion = trafficProportion;
            this.Started = started;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppStoreVersionExperimentUpdateRequestDataAttributes()
        {
        }

    }
}