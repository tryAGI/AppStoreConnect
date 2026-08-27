
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticLogsProductDataItemDiagnosticInsight
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insightsURL")]
        public string? InsightsURL { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insightsCategory")]
        public string? InsightsCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insightsString")]
        public string? InsightsString { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticInsight" /> class.
        /// </summary>
        /// <param name="insightsURL"></param>
        /// <param name="insightsCategory"></param>
        /// <param name="insightsString"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogsProductDataItemDiagnosticInsight(
            string? insightsURL,
            string? insightsCategory,
            string? insightsString)
        {
            this.InsightsURL = insightsURL;
            this.InsightsCategory = insightsCategory;
            this.InsightsString = insightsString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticInsight" /> class.
        /// </summary>
        public DiagnosticLogsProductDataItemDiagnosticInsight()
        {
        }

    }
}