
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionLocalizations")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizations? AppStoreVersionLocalizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsBuild? Build { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionPhasedRelease")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedRelease? AppStoreVersionPhasedRelease { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAppVersion")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersion? GameCenterAppVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routingAppCoverage")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverage? RoutingAppCoverage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreReviewDetail")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetail? AppStoreReviewDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionSubmission")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmission? AppStoreVersionSubmission { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperience")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperience? AppClipDefaultExperience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperiments")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperiments? AppStoreVersionExperiments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentsV2")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2? AppStoreVersionExperimentsV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerReviews")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsCustomerReviews? CustomerReviews { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternativeDistributionPackage")]
        public global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackage? AlternativeDistributionPackage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="appStoreVersionLocalizations"></param>
        /// <param name="build"></param>
        /// <param name="appStoreVersionPhasedRelease"></param>
        /// <param name="gameCenterAppVersion"></param>
        /// <param name="routingAppCoverage"></param>
        /// <param name="appStoreReviewDetail"></param>
        /// <param name="appStoreVersionSubmission"></param>
        /// <param name="appClipDefaultExperience"></param>
        /// <param name="appStoreVersionExperiments"></param>
        /// <param name="appStoreVersionExperimentsV2"></param>
        /// <param name="customerReviews"></param>
        /// <param name="alternativeDistributionPackage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionRelationships(
            global::AppStoreConnect.AppStoreVersionRelationshipsApp? app,
            global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizations? appStoreVersionLocalizations,
            global::AppStoreConnect.AppStoreVersionRelationshipsBuild? build,
            global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedRelease? appStoreVersionPhasedRelease,
            global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersion? gameCenterAppVersion,
            global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverage? routingAppCoverage,
            global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetail? appStoreReviewDetail,
            global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmission? appStoreVersionSubmission,
            global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperience? appClipDefaultExperience,
            global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperiments? appStoreVersionExperiments,
            global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2? appStoreVersionExperimentsV2,
            global::AppStoreConnect.AppStoreVersionRelationshipsCustomerReviews? customerReviews,
            global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackage? alternativeDistributionPackage)
        {
            this.App = app;
            this.AppStoreVersionLocalizations = appStoreVersionLocalizations;
            this.Build = build;
            this.AppStoreVersionPhasedRelease = appStoreVersionPhasedRelease;
            this.GameCenterAppVersion = gameCenterAppVersion;
            this.RoutingAppCoverage = routingAppCoverage;
            this.AppStoreReviewDetail = appStoreReviewDetail;
            this.AppStoreVersionSubmission = appStoreVersionSubmission;
            this.AppClipDefaultExperience = appClipDefaultExperience;
            this.AppStoreVersionExperiments = appStoreVersionExperiments;
            this.AppStoreVersionExperimentsV2 = appStoreVersionExperimentsV2;
            this.CustomerReviews = customerReviews;
            this.AlternativeDistributionPackage = alternativeDistributionPackage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionRelationships" /> class.
        /// </summary>
        public AppStoreVersionRelationships()
        {
        }

    }
}