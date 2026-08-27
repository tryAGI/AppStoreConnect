
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionExperimentV2CreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.Platform Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trafficProportion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrafficProportion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentV2CreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="platform"></param>
        /// <param name="trafficProportion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionExperimentV2CreateRequestDataAttributes(
            string name,
            global::AppStoreConnect.Platform platform,
            int trafficProportion)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Platform = platform;
            this.TrafficProportion = trafficProportion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentV2CreateRequestDataAttributes" /> class.
        /// </summary>
        public AppStoreVersionExperimentV2CreateRequestDataAttributes()
        {
        }

    }
}