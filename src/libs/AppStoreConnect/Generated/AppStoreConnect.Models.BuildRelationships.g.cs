
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preReleaseVersion")]
        public global::AppStoreConnect.BuildRelationshipsPreReleaseVersion? PreReleaseVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("individualTesters")]
        public global::AppStoreConnect.BuildRelationshipsIndividualTesters? IndividualTesters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaGroups")]
        public global::AppStoreConnect.BuildRelationshipsBetaGroups? BetaGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaBuildLocalizations")]
        public global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizations? BetaBuildLocalizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEncryptionDeclaration")]
        public global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclaration? AppEncryptionDeclaration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaAppReviewSubmission")]
        public global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmission? BetaAppReviewSubmission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.BuildRelationshipsApp? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildBetaDetail")]
        public global::AppStoreConnect.BuildRelationshipsBuildBetaDetail? BuildBetaDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.BuildRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icons")]
        public global::AppStoreConnect.BuildRelationshipsIcons? Icons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildBundles")]
        public global::AppStoreConnect.BuildRelationshipsBuildBundles? BuildBundles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildUpload")]
        public global::AppStoreConnect.BuildRelationshipsBuildUpload? BuildUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perfPowerMetrics")]
        public global::AppStoreConnect.BuildRelationshipsPerfPowerMetrics? PerfPowerMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticSignatures")]
        public global::AppStoreConnect.BuildRelationshipsDiagnosticSignatures? DiagnosticSignatures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRelationships" /> class.
        /// </summary>
        /// <param name="preReleaseVersion"></param>
        /// <param name="individualTesters"></param>
        /// <param name="betaGroups"></param>
        /// <param name="betaBuildLocalizations"></param>
        /// <param name="appEncryptionDeclaration"></param>
        /// <param name="betaAppReviewSubmission"></param>
        /// <param name="app"></param>
        /// <param name="buildBetaDetail"></param>
        /// <param name="appStoreVersion"></param>
        /// <param name="icons"></param>
        /// <param name="buildBundles"></param>
        /// <param name="buildUpload"></param>
        /// <param name="perfPowerMetrics"></param>
        /// <param name="diagnosticSignatures"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildRelationships(
            global::AppStoreConnect.BuildRelationshipsPreReleaseVersion? preReleaseVersion,
            global::AppStoreConnect.BuildRelationshipsIndividualTesters? individualTesters,
            global::AppStoreConnect.BuildRelationshipsBetaGroups? betaGroups,
            global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizations? betaBuildLocalizations,
            global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclaration? appEncryptionDeclaration,
            global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmission? betaAppReviewSubmission,
            global::AppStoreConnect.BuildRelationshipsApp? app,
            global::AppStoreConnect.BuildRelationshipsBuildBetaDetail? buildBetaDetail,
            global::AppStoreConnect.BuildRelationshipsAppStoreVersion? appStoreVersion,
            global::AppStoreConnect.BuildRelationshipsIcons? icons,
            global::AppStoreConnect.BuildRelationshipsBuildBundles? buildBundles,
            global::AppStoreConnect.BuildRelationshipsBuildUpload? buildUpload,
            global::AppStoreConnect.BuildRelationshipsPerfPowerMetrics? perfPowerMetrics,
            global::AppStoreConnect.BuildRelationshipsDiagnosticSignatures? diagnosticSignatures)
        {
            this.PreReleaseVersion = preReleaseVersion;
            this.IndividualTesters = individualTesters;
            this.BetaGroups = betaGroups;
            this.BetaBuildLocalizations = betaBuildLocalizations;
            this.AppEncryptionDeclaration = appEncryptionDeclaration;
            this.BetaAppReviewSubmission = betaAppReviewSubmission;
            this.App = app;
            this.BuildBetaDetail = buildBetaDetail;
            this.AppStoreVersion = appStoreVersion;
            this.Icons = icons;
            this.BuildBundles = buildBundles;
            this.BuildUpload = buildUpload;
            this.PerfPowerMetrics = perfPowerMetrics;
            this.DiagnosticSignatures = diagnosticSignatures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildRelationships" /> class.
        /// </summary>
        public BuildRelationships()
        {
        }

    }
}