
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsBetaTesterUsagesV1MetricResponseDataItemDimensions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaTesters")]
        public global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTesters? BetaTesters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsBetaTesterUsagesV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        /// <param name="betaTesters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppsBetaTesterUsagesV1MetricResponseDataItemDimensions(
            global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDimensionsBetaTesters? betaTesters)
        {
            this.BetaTesters = betaTesters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsBetaTesterUsagesV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        public AppsBetaTesterUsagesV1MetricResponseDataItemDimensions()
        {
        }

    }
}