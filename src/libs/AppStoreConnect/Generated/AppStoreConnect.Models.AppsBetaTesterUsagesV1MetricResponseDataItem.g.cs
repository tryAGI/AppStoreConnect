
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppsBetaTesterUsagesV1MetricResponseDataItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataPoints")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDataPoint>? DataPoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDimensions? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsBetaTesterUsagesV1MetricResponseDataItem" /> class.
        /// </summary>
        /// <param name="dataPoints"></param>
        /// <param name="dimensions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppsBetaTesterUsagesV1MetricResponseDataItem(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDataPoint>? dataPoints,
            global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponseDataItemDimensions? dimensions)
        {
            this.DataPoints = dataPoints;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsBetaTesterUsagesV1MetricResponseDataItem" /> class.
        /// </summary>
        public AppsBetaTesterUsagesV1MetricResponseDataItem()
        {
        }

    }
}