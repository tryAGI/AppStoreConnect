
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaBuildUsagesV1MetricResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataPoints")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPoint>? DataPoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildUsagesV1MetricResponseDataItem" /> class.
        /// </summary>
        /// <param name="dataPoints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBuildUsagesV1MetricResponseDataItem(
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPoint>? dataPoints)
        {
            this.DataPoints = dataPoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildUsagesV1MetricResponseDataItem" /> class.
        /// </summary>
        public BetaBuildUsagesV1MetricResponseDataItem()
        {
        }

    }
}