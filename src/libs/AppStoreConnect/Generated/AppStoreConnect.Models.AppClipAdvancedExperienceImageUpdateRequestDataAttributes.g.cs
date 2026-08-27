
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceImageUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFileChecksum")]
        public string? SourceFileChecksum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded")]
        public bool? Uploaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceImageUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="sourceFileChecksum"></param>
        /// <param name="uploaded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceImageUpdateRequestDataAttributes(
            string? sourceFileChecksum,
            bool? uploaded)
        {
            this.SourceFileChecksum = sourceFileChecksum;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceImageUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppClipAdvancedExperienceImageUpdateRequestDataAttributes()
        {
        }

    }
}