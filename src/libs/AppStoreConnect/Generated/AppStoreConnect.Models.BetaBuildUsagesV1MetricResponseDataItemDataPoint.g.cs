
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaBuildUsagesV1MetricResponseDataItemDataPoint
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPointValues? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildUsagesV1MetricResponseDataItemDataPoint" /> class.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBuildUsagesV1MetricResponseDataItemDataPoint(
            global::System.DateTime? start,
            global::System.DateTime? end,
            global::AppStoreConnect.BetaBuildUsagesV1MetricResponseDataItemDataPointValues? values)
        {
            this.Start = start;
            this.End = end;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildUsagesV1MetricResponseDataItemDataPoint" /> class.
        /// </summary>
        public BetaBuildUsagesV1MetricResponseDataItemDataPoint()
        {
        }

    }
}