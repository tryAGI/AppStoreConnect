
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiIssueCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzerWarnings")]
        public int? AnalyzerWarnings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public int? Errors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testFailures")]
        public int? TestFailures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public int? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiIssueCounts" /> class.
        /// </summary>
        /// <param name="analyzerWarnings"></param>
        /// <param name="errors"></param>
        /// <param name="testFailures"></param>
        /// <param name="warnings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiIssueCounts(
            int? analyzerWarnings,
            int? errors,
            int? testFailures,
            int? warnings)
        {
            this.AnalyzerWarnings = analyzerWarnings;
            this.Errors = errors;
            this.TestFailures = testFailures;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiIssueCounts" /> class.
        /// </summary>
        public CiIssueCounts()
        {
        }

    }
}