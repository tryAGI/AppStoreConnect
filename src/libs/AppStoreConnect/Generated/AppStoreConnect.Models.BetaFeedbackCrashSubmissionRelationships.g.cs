
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaFeedbackCrashSubmissionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crashLog")]
        public global::AppStoreConnect.BetaFeedbackCrashSubmissionRelationshipsCrashLog? CrashLog { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.BetaFeedbackCrashSubmissionRelationshipsBuild? Build { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tester")]
        public global::AppStoreConnect.BetaFeedbackCrashSubmissionRelationshipsTester? Tester { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFeedbackCrashSubmissionRelationships" /> class.
        /// </summary>
        /// <param name="crashLog"></param>
        /// <param name="build"></param>
        /// <param name="tester"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFeedbackCrashSubmissionRelationships(
            global::AppStoreConnect.BetaFeedbackCrashSubmissionRelationshipsCrashLog? crashLog,
            global::AppStoreConnect.BetaFeedbackCrashSubmissionRelationshipsBuild? build,
            global::AppStoreConnect.BetaFeedbackCrashSubmissionRelationshipsTester? tester)
        {
            this.CrashLog = crashLog;
            this.Build = build;
            this.Tester = tester;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFeedbackCrashSubmissionRelationships" /> class.
        /// </summary>
        public BetaFeedbackCrashSubmissionRelationships()
        {
        }

    }
}