
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTesterUsagesV1MetricResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataPoints")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDataPoint>? DataPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDimensions? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItem" /> class.
        /// </summary>
        /// <param name="dataPoints"></param>
        /// <param name="dimensions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterUsagesV1MetricResponseDataItem(
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDataPoint>? dataPoints,
            global::AppStoreConnect.BetaTesterUsagesV1MetricResponseDataItemDimensions? dimensions)
        {
            this.DataPoints = dataPoints;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItem" /> class.
        /// </summary>
        public BetaTesterUsagesV1MetricResponseDataItem()
        {
        }

    }
}