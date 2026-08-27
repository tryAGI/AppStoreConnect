
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsInsightPopulation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deltaPercentage")]
        public double? DeltaPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public string? Percentile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryString")]
        public string? SummaryString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAverageValue")]
        public double? ReferenceAverageValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersionValue")]
        public double? LatestVersionValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        public string? Device { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsInsightPopulation" /> class.
        /// </summary>
        /// <param name="deltaPercentage"></param>
        /// <param name="percentile"></param>
        /// <param name="summaryString"></param>
        /// <param name="referenceAverageValue"></param>
        /// <param name="latestVersionValue"></param>
        /// <param name="device"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricsInsightPopulation(
            double? deltaPercentage,
            string? percentile,
            string? summaryString,
            double? referenceAverageValue,
            double? latestVersionValue,
            string? device)
        {
            this.DeltaPercentage = deltaPercentage;
            this.Percentile = percentile;
            this.SummaryString = summaryString;
            this.ReferenceAverageValue = referenceAverageValue;
            this.LatestVersionValue = latestVersionValue;
            this.Device = device;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsInsightPopulation" /> class.
        /// </summary>
        public MetricsInsightPopulation()
        {
        }

    }
}