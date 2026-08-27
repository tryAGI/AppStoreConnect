
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticInsightReferenceVersion
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticInsightReferenceVersion" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticInsightReferenceVersion(
            string? version,
            double? value)
        {
            this.Version = version;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticInsightReferenceVersion" /> class.
        /// </summary>
        public DiagnosticInsightReferenceVersion()
        {
        }

    }
}