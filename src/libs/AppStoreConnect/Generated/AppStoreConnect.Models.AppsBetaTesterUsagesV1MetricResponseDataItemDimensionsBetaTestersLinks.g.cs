
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTestersLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related")]
        public string? Related { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTestersLinks" /> class.
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="related"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTestersLinks(
            string? groupBy,
            string? related)
        {
            this.GroupBy = groupBy;
            this.Related = related;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTestersLinks" /> class.
        /// </summary>
        public AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTestersLinks()
        {
        }

    }
}