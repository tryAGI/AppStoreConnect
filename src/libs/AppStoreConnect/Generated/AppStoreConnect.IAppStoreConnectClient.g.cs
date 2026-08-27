
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAppStoreConnectClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::AppStoreConnect.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::AppStoreConnect.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AccessibilityDeclarationsClient AccessibilityDeclarations { get; }

        /// <summary>
        /// 
        /// </summary>
        public ActorsClient Actors { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgeRatingDeclarationsClient AgeRatingDeclarations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AlternativeDistributionDomainsClient AlternativeDistributionDomains { get; }

        /// <summary>
        /// 
        /// </summary>
        public AlternativeDistributionKeysClient AlternativeDistributionKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public AlternativeDistributionPackageDeltasClient AlternativeDistributionPackageDeltas { get; }

        /// <summary>
        /// 
        /// </summary>
        public AlternativeDistributionPackageVariantsClient AlternativeDistributionPackageVariants { get; }

        /// <summary>
        /// 
        /// </summary>
        public AlternativeDistributionPackageVersionsClient AlternativeDistributionPackageVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public AlternativeDistributionPackagesClient AlternativeDistributionPackages { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsReportInstancesClient AnalyticsReportInstances { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsReportRequestsClient AnalyticsReportRequests { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsReportSegmentsClient AnalyticsReportSegments { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsReportsClient AnalyticsReports { get; }

        /// <summary>
        /// 
        /// </summary>
        public AndroidToIosAppMappingDetailsClient AndroidToIosAppMappingDetails { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppAvailabilitiesClient AppAvailabilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppCategoriesClient AppCategories { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClipAdvancedExperienceImagesClient AppClipAdvancedExperienceImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClipAdvancedExperiencesClient AppClipAdvancedExperiences { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClipAppStoreReviewDetailsClient AppClipAppStoreReviewDetails { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClipDefaultExperienceLocalizationsClient AppClipDefaultExperienceLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClipDefaultExperiencesClient AppClipDefaultExperiences { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClipHeaderImagesClient AppClipHeaderImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClipsClient AppClips { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppCustomProductPageLocalizationsClient AppCustomProductPageLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppCustomProductPageVersionsClient AppCustomProductPageVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppCustomProductPagesClient AppCustomProductPages { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppEncryptionDeclarationDocumentsClient AppEncryptionDeclarationDocuments { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppEncryptionDeclarationsClient AppEncryptionDeclarations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppEventLocalizationsClient AppEventLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppEventScreenshotsClient AppEventScreenshots { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppEventVideoClipsClient AppEventVideoClips { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppEventsClient AppEvents { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppInfoLocalizationsClient AppInfoLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppInfosClient AppInfos { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppPreviewSetsClient AppPreviewSets { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppPreviewsClient AppPreviews { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppPricePointsClient AppPricePoints { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppPriceSchedulesClient AppPriceSchedules { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppScreenshotSetsClient AppScreenshotSets { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppScreenshotsClient AppScreenshots { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreReviewAttachmentsClient AppStoreReviewAttachments { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreReviewDetailsClient AppStoreReviewDetails { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionExperimentTreatmentLocalizationsClient AppStoreVersionExperimentTreatmentLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionExperimentTreatmentsClient AppStoreVersionExperimentTreatments { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionExperimentsClient AppStoreVersionExperiments { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionLocalizationsClient AppStoreVersionLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionPhasedReleasesClient AppStoreVersionPhasedReleases { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionPromotionsClient AppStoreVersionPromotions { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionReleaseRequestsClient AppStoreVersionReleaseRequests { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppStoreVersionsClient AppStoreVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppTagsClient AppTags { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppsClient Apps { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackgroundAssetUploadFilesClient BackgroundAssetUploadFiles { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackgroundAssetVersionAppStoreReleasesClient BackgroundAssetVersionAppStoreReleases { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackgroundAssetVersionExternalBetaReleasesClient BackgroundAssetVersionExternalBetaReleases { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackgroundAssetVersionInternalBetaReleasesClient BackgroundAssetVersionInternalBetaReleases { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackgroundAssetVersionsClient BackgroundAssetVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackgroundAssetsClient BackgroundAssets { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaAppClipInvocationLocalizationsClient BetaAppClipInvocationLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaAppClipInvocationsClient BetaAppClipInvocations { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaAppLocalizationsClient BetaAppLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaAppReviewDetailsClient BetaAppReviewDetails { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaAppReviewSubmissionsClient BetaAppReviewSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaBuildLocalizationsClient BetaBuildLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaCrashLogsClient BetaCrashLogs { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaFeedbackCrashSubmissionsClient BetaFeedbackCrashSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaFeedbackScreenshotSubmissionsClient BetaFeedbackScreenshotSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaGroupsClient BetaGroups { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaLicenseAgreementsClient BetaLicenseAgreements { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaRecruitmentCriteriaClient BetaRecruitmentCriteria { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaRecruitmentCriterionOptionsClient BetaRecruitmentCriterionOptions { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaTesterInvitationsClient BetaTesterInvitations { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaTestersClient BetaTesters { get; }

        /// <summary>
        /// 
        /// </summary>
        public BuildBetaDetailsClient BuildBetaDetails { get; }

        /// <summary>
        /// 
        /// </summary>
        public BuildBetaNotificationsClient BuildBetaNotifications { get; }

        /// <summary>
        /// 
        /// </summary>
        public BuildBundlesClient BuildBundles { get; }

        /// <summary>
        /// 
        /// </summary>
        public BuildUploadFilesClient BuildUploadFiles { get; }

        /// <summary>
        /// 
        /// </summary>
        public BuildUploadsClient BuildUploads { get; }

        /// <summary>
        /// 
        /// </summary>
        public BuildsClient Builds { get; }

        /// <summary>
        /// 
        /// </summary>
        public BundleIdCapabilitiesClient BundleIdCapabilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public BundleIdsClient BundleIds { get; }

        /// <summary>
        /// 
        /// </summary>
        public CertificatesClient Certificates { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiArtifactsClient CiArtifacts { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiBuildActionsClient CiBuildActions { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiBuildRunsClient CiBuildRuns { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiIssuesClient CiIssues { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiMacOsVersionsClient CiMacOsVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiProductsClient CiProducts { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiTestResultsClient CiTestResults { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiWorkflowsClient CiWorkflows { get; }

        /// <summary>
        /// 
        /// </summary>
        public CiXcodeVersionsClient CiXcodeVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomerReviewResponsesClient CustomerReviewResponses { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomerReviewsClient CustomerReviews { get; }

        /// <summary>
        /// 
        /// </summary>
        public DevicesClient Devices { get; }

        /// <summary>
        /// 
        /// </summary>
        public DiagnosticSignaturesClient DiagnosticSignatures { get; }

        /// <summary>
        /// 
        /// </summary>
        public EndAppAvailabilityPreOrdersClient EndAppAvailabilityPreOrders { get; }

        /// <summary>
        /// 
        /// </summary>
        public EndUserLicenseAgreementsClient EndUserLicenseAgreements { get; }

        /// <summary>
        /// 
        /// </summary>
        public FinanceReportsClient FinanceReports { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterAchievementImagesClient GameCenterAchievementImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterAchievementLocalizationsClient GameCenterAchievementLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterAchievementVersionsClient GameCenterAchievementVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterAchievementsClient GameCenterAchievements { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterActivitiesClient GameCenterActivities { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterActivityImagesClient GameCenterActivityImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterActivityLocalizationsClient GameCenterActivityLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterActivityVersionsClient GameCenterActivityVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterAppVersionsClient GameCenterAppVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterChallengeImagesClient GameCenterChallengeImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterChallengeLocalizationsClient GameCenterChallengeLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterChallengeVersionsClient GameCenterChallengeVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterChallengesClient GameCenterChallenges { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterDetailsClient GameCenterDetails { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterGroupsClient GameCenterGroups { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardEntrySubmissionsClient GameCenterLeaderboardEntrySubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardImagesClient GameCenterLeaderboardImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardLocalizationsClient GameCenterLeaderboardLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardSetImagesClient GameCenterLeaderboardSetImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardSetLocalizationsClient GameCenterLeaderboardSetLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardSetMemberLocalizationsClient GameCenterLeaderboardSetMemberLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardSetVersionsClient GameCenterLeaderboardSetVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardSetsClient GameCenterLeaderboardSets { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardVersionsClient GameCenterLeaderboardVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterLeaderboardsClient GameCenterLeaderboards { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterMatchmakingQueuesClient GameCenterMatchmakingQueues { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterMatchmakingRuleSetTestsClient GameCenterMatchmakingRuleSetTests { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterMatchmakingRuleSetsClient GameCenterMatchmakingRuleSets { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterMatchmakingRulesClient GameCenterMatchmakingRules { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterMatchmakingTeamsClient GameCenterMatchmakingTeams { get; }

        /// <summary>
        /// 
        /// </summary>
        public GameCenterPlayerAchievementSubmissionsClient GameCenterPlayerAchievementSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseAppStoreReviewScreenshotsClient InAppPurchaseAppStoreReviewScreenshots { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseAvailabilitiesClient InAppPurchaseAvailabilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseContentsClient InAppPurchaseContents { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseImagesClient InAppPurchaseImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseLocalizationsClient InAppPurchaseLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseOfferCodeCustomCodesClient InAppPurchaseOfferCodeCustomCodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseOfferCodeOneTimeUseCodesClient InAppPurchaseOfferCodeOneTimeUseCodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseOfferCodesClient InAppPurchaseOfferCodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchasePricePointsClient InAppPurchasePricePoints { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchasePriceSchedulesClient InAppPurchasePriceSchedules { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseSubmissionsClient InAppPurchaseSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchaseVersionsClient InAppPurchaseVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public InAppPurchasesClient InAppPurchases { get; }

        /// <summary>
        /// 
        /// </summary>
        public MarketplaceSearchDetailsClient MarketplaceSearchDetails { get; }

        /// <summary>
        /// 
        /// </summary>
        public MerchantIdsClient MerchantIds { get; }

        /// <summary>
        /// 
        /// </summary>
        public NominationsClient Nominations { get; }

        /// <summary>
        /// 
        /// </summary>
        public PassTypeIdsClient PassTypeIds { get; }

        /// <summary>
        /// 
        /// </summary>
        public PreReleaseVersionsClient PreReleaseVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProfilesClient Profiles { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromotedPurchasesClient PromotedPurchases { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReviewSubmissionItemsClient ReviewSubmissionItems { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReviewSubmissionsClient ReviewSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public RoutingAppCoveragesClient RoutingAppCoverages { get; }

        /// <summary>
        /// 
        /// </summary>
        public SalesReportsClient SalesReports { get; }

        /// <summary>
        /// 
        /// </summary>
        public SandboxTestersClient SandboxTesters { get; }

        /// <summary>
        /// 
        /// </summary>
        public SandboxTestersClearPurchaseHistoryRequestClient SandboxTestersClearPurchaseHistoryRequest { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScmGitReferencesClient ScmGitReferences { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScmProvidersClient ScmProviders { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScmPullRequestsClient ScmPullRequests { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScmRepositoriesClient ScmRepositories { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionAppStoreReviewScreenshotsClient SubscriptionAppStoreReviewScreenshots { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionGracePeriodsClient SubscriptionGracePeriods { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionGroupLocalizationsClient SubscriptionGroupLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionGroupSubmissionsClient SubscriptionGroupSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionGroupVersionsClient SubscriptionGroupVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionGroupsClient SubscriptionGroups { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionImagesClient SubscriptionImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionIntroductoryOffersClient SubscriptionIntroductoryOffers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionLocalizationsClient SubscriptionLocalizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionOfferCodeCustomCodesClient SubscriptionOfferCodeCustomCodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionOfferCodeOneTimeUseCodesClient SubscriptionOfferCodeOneTimeUseCodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionOfferCodesClient SubscriptionOfferCodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionPlanAvailabilitiesClient SubscriptionPlanAvailabilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionPricePointsClient SubscriptionPricePoints { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionPricesClient SubscriptionPrices { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionPromotionalOffersClient SubscriptionPromotionalOffers { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionSubmissionsClient SubscriptionSubmissions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionVersionsClient SubscriptionVersions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TerritoriesClient Territories { get; }

        /// <summary>
        /// 
        /// </summary>
        public TerritoryAvailabilitiesClient TerritoryAvailabilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserInvitationsClient UserInvitations { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhookDeliveriesClient WebhookDeliveries { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhookPingsClient WebhookPings { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

        /// <summary>
        /// 
        /// </summary>
        public WinBackOffersClient WinBackOffers { get; }

    }
}