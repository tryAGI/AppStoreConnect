
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsReportSegmentAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksum")]
        public string? Checksum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        public long? SizeInBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportSegmentAttributes" /> class.
        /// </summary>
        /// <param name="checksum"></param>
        /// <param name="sizeInBytes"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsReportSegmentAttributes(
            string? checksum,
            long? sizeInBytes,
            string? url)
        {
            this.Checksum = checksum;
            this.SizeInBytes = sizeInBytes;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportSegmentAttributes" /> class.
        /// </summary>
        public AnalyticsReportSegmentAttributes()
        {
        }

    }
}