
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeOverviewCategorieSectionDatasetPoint
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMargin")]
        public double? ErrorMargin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentageBreakdown")]
        public global::AppStoreConnect.XcodeOverviewCategorieSectionDatasetPointPercentageBreakdown? PercentageBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorieSectionDatasetPoint" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="value"></param>
        /// <param name="errorMargin"></param>
        /// <param name="percentageBreakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeOverviewCategorieSectionDatasetPoint(
            string? version,
            double? value,
            double? errorMargin,
            global::AppStoreConnect.XcodeOverviewCategorieSectionDatasetPointPercentageBreakdown? percentageBreakdown)
        {
            this.Version = version;
            this.Value = value;
            this.ErrorMargin = errorMargin;
            this.PercentageBreakdown = percentageBreakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorieSectionDatasetPoint" /> class.
        /// </summary>
        public XcodeOverviewCategorieSectionDatasetPoint()
        {
        }

    }
}