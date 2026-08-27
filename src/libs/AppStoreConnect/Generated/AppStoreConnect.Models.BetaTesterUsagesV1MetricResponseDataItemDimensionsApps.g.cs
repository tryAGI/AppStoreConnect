
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaTesterUsagesV1MetricResponseDataItemDimensionsApps
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDimensionsAppsLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItemDimensionsApps" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterUsagesV1MetricResponseDataItemDimensionsApps(
            global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDimensionsAppsLinks? links,
            string? data)
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItemDimensionsApps" /> class.
        /// </summary>
        public BetaTesterUsagesV1MetricResponseDataItemDimensionsApps()
        {
        }

    }
}