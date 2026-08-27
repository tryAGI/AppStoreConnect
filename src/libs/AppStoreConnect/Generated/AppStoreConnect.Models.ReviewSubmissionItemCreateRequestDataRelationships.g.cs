
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewSubmissionItemCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewSubmission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmission ReviewSubmission { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersion? AppCustomProductPageVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperiment")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperiment? AppStoreVersionExperiment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentV2")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2? AppStoreVersionExperimentV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEvent")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEvent? AppEvent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundAssetVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersion? BackgroundAssetVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievementVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersion? GameCenterAchievementVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterActivityVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersion? GameCenterActivityVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterChallengeVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersion? GameCenterChallengeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSetVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersion? GameCenterLeaderboardSetVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersion? GameCenterLeaderboardVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersion? InAppPurchaseVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersion? SubscriptionVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGroupVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersion? SubscriptionGroupVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="reviewSubmission"></param>
        /// <param name="appStoreVersion"></param>
        /// <param name="appCustomProductPageVersion"></param>
        /// <param name="appStoreVersionExperiment"></param>
        /// <param name="appStoreVersionExperimentV2"></param>
        /// <param name="appEvent"></param>
        /// <param name="backgroundAssetVersion"></param>
        /// <param name="gameCenterAchievementVersion"></param>
        /// <param name="gameCenterActivityVersion"></param>
        /// <param name="gameCenterChallengeVersion"></param>
        /// <param name="gameCenterLeaderboardSetVersion"></param>
        /// <param name="gameCenterLeaderboardVersion"></param>
        /// <param name="inAppPurchaseVersion"></param>
        /// <param name="subscriptionVersion"></param>
        /// <param name="subscriptionGroupVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSubmissionItemCreateRequestDataRelationships(
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmission reviewSubmission,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersion? appStoreVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersion? appCustomProductPageVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperiment? appStoreVersionExperiment,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2? appStoreVersionExperimentV2,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEvent? appEvent,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersion? backgroundAssetVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersion? gameCenterAchievementVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersion? gameCenterActivityVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersion? gameCenterChallengeVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersion? gameCenterLeaderboardSetVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersion? gameCenterLeaderboardVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersion? inAppPurchaseVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersion? subscriptionVersion,
            global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersion? subscriptionGroupVersion)
        {
            this.ReviewSubmission = reviewSubmission ?? throw new global::System.ArgumentNullException(nameof(reviewSubmission));
            this.AppStoreVersion = appStoreVersion;
            this.AppCustomProductPageVersion = appCustomProductPageVersion;
            this.AppStoreVersionExperiment = appStoreVersionExperiment;
            this.AppStoreVersionExperimentV2 = appStoreVersionExperimentV2;
            this.AppEvent = appEvent;
            this.BackgroundAssetVersion = backgroundAssetVersion;
            this.GameCenterAchievementVersion = gameCenterAchievementVersion;
            this.GameCenterActivityVersion = gameCenterActivityVersion;
            this.GameCenterChallengeVersion = gameCenterChallengeVersion;
            this.GameCenterLeaderboardSetVersion = gameCenterLeaderboardSetVersion;
            this.GameCenterLeaderboardVersion = gameCenterLeaderboardVersion;
            this.InAppPurchaseVersion = inAppPurchaseVersion;
            this.SubscriptionVersion = subscriptionVersion;
            this.SubscriptionGroupVersion = subscriptionGroupVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemCreateRequestDataRelationships" /> class.
        /// </summary>
        public ReviewSubmissionItemCreateRequestDataRelationships()
        {
        }

    }
}