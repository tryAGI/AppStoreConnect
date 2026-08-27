
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTesterUsagesV1MetricResponseDataItemDimensions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDimensionsApps? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        /// <param name="apps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterUsagesV1MetricResponseDataItemDimensions(
            global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDimensionsApps? apps)
        {
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        public BetaTesterUsagesV1MetricResponseDataItemDimensions()
        {
        }

    }
}