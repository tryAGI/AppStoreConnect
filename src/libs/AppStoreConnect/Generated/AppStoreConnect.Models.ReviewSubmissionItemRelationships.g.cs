
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewSubmissionItemRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersion? AppCustomProductPageVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperiment")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperiment? AppStoreVersionExperiment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentV2")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2? AppStoreVersionExperimentV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEvent")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEvent? AppEvent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundAssetVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersion? BackgroundAssetVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievementVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersion? GameCenterAchievementVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterActivityVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersion? GameCenterActivityVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterChallengeVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersion? GameCenterChallengeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSetVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersion? GameCenterLeaderboardSetVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersion? GameCenterLeaderboardVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersion? InAppPurchaseVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersion? SubscriptionVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGroupVersion")]
        public global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersion? SubscriptionGroupVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemRelationships" /> class.
        /// </summary>
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
        public ReviewSubmissionItemRelationships(
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersion? appStoreVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppCustomProductPageVersion? appCustomProductPageVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperiment? appStoreVersionExperiment,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppStoreVersionExperimentV2? appStoreVersionExperimentV2,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsAppEvent? appEvent,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsBackgroundAssetVersion? backgroundAssetVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterAchievementVersion? gameCenterAchievementVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterActivityVersion? gameCenterActivityVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterChallengeVersion? gameCenterChallengeVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersion? gameCenterLeaderboardSetVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsGameCenterLeaderboardVersion? gameCenterLeaderboardVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsInAppPurchaseVersion? inAppPurchaseVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionVersion? subscriptionVersion,
            global::AppStoreConnect.ReviewSubmissionItemRelationshipsSubscriptionGroupVersion? subscriptionGroupVersion)
        {
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
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemRelationships" /> class.
        /// </summary>
        public ReviewSubmissionItemRelationships()
        {
        }

    }
}