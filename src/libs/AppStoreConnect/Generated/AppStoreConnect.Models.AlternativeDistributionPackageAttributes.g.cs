
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlternativeDistributionPackageAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFileChecksum")]
        public global::AppStoreConnect.Checksums? SourceFileChecksum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageAttributes" /> class.
        /// </summary>
        /// <param name="sourceFileChecksum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionPackageAttributes(
            global::AppStoreConnect.Checksums? sourceFileChecksum)
        {
            this.SourceFileChecksum = sourceFileChecksum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageAttributes" /> class.
        /// </summary>
        public AlternativeDistributionPackageAttributes()
        {
        }

    }
}