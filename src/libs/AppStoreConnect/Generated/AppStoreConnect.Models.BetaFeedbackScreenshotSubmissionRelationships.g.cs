
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaFeedbackScreenshotSubmissionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuild? Build { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tester")]
        public global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTester? Tester { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFeedbackScreenshotSubmissionRelationships" /> class.
        /// </summary>
        /// <param name="build"></param>
        /// <param name="tester"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFeedbackScreenshotSubmissionRelationships(
            global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsBuild? build,
            global::AppStoreConnect.BetaFeedbackScreenshotSubmissionRelationshipsTester? tester)
        {
            this.Build = build;
            this.Tester = tester;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFeedbackScreenshotSubmissionRelationships" /> class.
        /// </summary>
        public BetaFeedbackScreenshotSubmissionRelationships()
        {
        }

    }
}