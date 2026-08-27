
#nullable enable

namespace AppStoreConnect
{
    public partial class AppsClient
    {


        private static readonly global::AppStoreConnect.EndPointSecurityRequirement s_AppsGetCollectionSecurityRequirement0 =
            new global::AppStoreConnect.EndPointSecurityRequirement
            {
                Authorizations = new global::AppStoreConnect.EndPointAuthorizationRequirement[]
                {                    new global::AppStoreConnect.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::AppStoreConnect.EndPointSecurityRequirement[] s_AppsGetCollectionSecurityRequirements =
            new global::AppStoreConnect.EndPointSecurityRequirement[]
            {                s_AppsGetCollectionSecurityRequirement0,
            };
        partial void PrepareAppsGetCollectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? filterName,
            global::System.Collections.Generic.IList<string>? filterBundleId,
            global::System.Collections.Generic.IList<string>? filterSku,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem>? filterAppStoreVersionsAppStoreState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem>? filterAppStoreVersionsPlatform,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem>? filterAppStoreVersionsAppVersionState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem>? filterReviewSubmissionsState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem>? filterReviewSubmissionsPlatform,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersions,
            global::System.Collections.Generic.IList<string>? filterId,
            ref bool? existsGameCenterEnabledVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionSortItem>? sort,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon>? fieldsBuildIcons,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsCiProduct>? fieldsCiProducts,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup>? fieldsBetaGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization>? fieldsBetaAppLocalizations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuild>? fieldsBuilds,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppInfo>? fieldsAppInfos,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppClip>? fieldsAppClips,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase>? fieldsInAppPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup>? fieldsSubscriptionGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage>? fieldsAppCustomProductPages,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase>? fieldsPromotedPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEvent>? fieldsAppEvents,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission>? fieldsReviewSubmissions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail>? fieldsGameCenterDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails,
            ref int? limit,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionIncludeItem>? include,
            ref int? limitAndroidToIosAppMappingDetails,
            ref int? limitAppClips,
            ref int? limitAppCustomProductPages,
            ref int? limitAppEncryptionDeclarations,
            ref int? limitAppEvents,
            ref int? limitAppInfos,
            ref int? limitAppStoreVersionExperimentsV2,
            ref int? limitAppStoreVersions,
            ref int? limitBetaAppLocalizations,
            ref int? limitBetaGroups,
            ref int? limitBuilds,
            ref int? limitGameCenterEnabledVersions,
            ref int? limitInAppPurchases,
            ref int? limitInAppPurchasesV2,
            ref int? limitPreReleaseVersions,
            ref int? limitPromotedPurchases,
            ref int? limitReviewSubmissions,
            ref int? limitSubscriptionGroups);
        partial void PrepareAppsGetCollectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? filterName,
            global::System.Collections.Generic.IList<string>? filterBundleId,
            global::System.Collections.Generic.IList<string>? filterSku,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem>? filterAppStoreVersionsAppStoreState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem>? filterAppStoreVersionsPlatform,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem>? filterAppStoreVersionsAppVersionState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem>? filterReviewSubmissionsState,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem>? filterReviewSubmissionsPlatform,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersions,
            global::System.Collections.Generic.IList<string>? filterId,
            bool? existsGameCenterEnabledVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionSortItem>? sort,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon>? fieldsBuildIcons,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsCiProduct>? fieldsCiProducts,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup>? fieldsBetaGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization>? fieldsBetaAppLocalizations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuild>? fieldsBuilds,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppInfo>? fieldsAppInfos,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppClip>? fieldsAppClips,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase>? fieldsInAppPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup>? fieldsSubscriptionGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage>? fieldsAppCustomProductPages,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase>? fieldsPromotedPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEvent>? fieldsAppEvents,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission>? fieldsReviewSubmissions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail>? fieldsGameCenterDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails,
            int? limit,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionIncludeItem>? include,
            int? limitAndroidToIosAppMappingDetails,
            int? limitAppClips,
            int? limitAppCustomProductPages,
            int? limitAppEncryptionDeclarations,
            int? limitAppEvents,
            int? limitAppInfos,
            int? limitAppStoreVersionExperimentsV2,
            int? limitAppStoreVersions,
            int? limitBetaAppLocalizations,
            int? limitBetaGroups,
            int? limitBuilds,
            int? limitGameCenterEnabledVersions,
            int? limitInAppPurchases,
            int? limitInAppPurchasesV2,
            int? limitPreReleaseVersions,
            int? limitPromotedPurchases,
            int? limitReviewSubmissions,
            int? limitSubscriptionGroups);
        partial void ProcessAppsGetCollectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppsGetCollectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterBundleId"></param>
        /// <param name="filterSku"></param>
        /// <param name="filterAppStoreVersionsAppStoreState"></param>
        /// <param name="filterAppStoreVersionsPlatform"></param>
        /// <param name="filterAppStoreVersionsAppVersionState"></param>
        /// <param name="filterReviewSubmissionsState"></param>
        /// <param name="filterReviewSubmissionsPlatform"></param>
        /// <param name="filterAppStoreVersions"></param>
        /// <param name="filterId"></param>
        /// <param name="existsGameCenterEnabledVersions"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsBuildIcons"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBetaAppLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaLicenseAgreements"></param>
        /// <param name="fieldsBetaAppReviewDetails"></param>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsEndUserLicenseAgreements"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsGameCenterEnabledVersions"></param>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsSubscriptionGracePeriods"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAndroidToIosAppMappingDetails"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAndroidToIosAppMappingDetails"></param>
        /// <param name="limitAppClips"></param>
        /// <param name="limitAppCustomProductPages"></param>
        /// <param name="limitAppEncryptionDeclarations"></param>
        /// <param name="limitAppEvents"></param>
        /// <param name="limitAppInfos"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="limitAppStoreVersions"></param>
        /// <param name="limitBetaAppLocalizations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="limitGameCenterEnabledVersions"></param>
        /// <param name="limitInAppPurchases"></param>
        /// <param name="limitInAppPurchasesV2"></param>
        /// <param name="limitPreReleaseVersions"></param>
        /// <param name="limitPromotedPurchases"></param>
        /// <param name="limitReviewSubmissions"></param>
        /// <param name="limitSubscriptionGroups"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.AppsResponse> AppsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterBundleId = default,
            global::System.Collections.Generic.IList<string>? filterSku = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem>? filterAppStoreVersionsAppStoreState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem>? filterAppStoreVersionsPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem>? filterAppStoreVersionsAppVersionState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem>? filterReviewSubmissionsState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem>? filterReviewSubmissionsPlatform = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersions = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            bool? existsGameCenterEnabledVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization>? fieldsBetaAppLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionIncludeItem>? include = default,
            int? limitAndroidToIosAppMappingDetails = default,
            int? limitAppClips = default,
            int? limitAppCustomProductPages = default,
            int? limitAppEncryptionDeclarations = default,
            int? limitAppEvents = default,
            int? limitAppInfos = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            int? limitAppStoreVersions = default,
            int? limitBetaAppLocalizations = default,
            int? limitBetaGroups = default,
            int? limitBuilds = default,
            int? limitGameCenterEnabledVersions = default,
            int? limitInAppPurchases = default,
            int? limitInAppPurchasesV2 = default,
            int? limitPreReleaseVersions = default,
            int? limitPromotedPurchases = default,
            int? limitReviewSubmissions = default,
            int? limitSubscriptionGroups = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AppsGetCollectionAsResponseAsync(
                filterName: filterName,
                filterBundleId: filterBundleId,
                filterSku: filterSku,
                filterAppStoreVersionsAppStoreState: filterAppStoreVersionsAppStoreState,
                filterAppStoreVersionsPlatform: filterAppStoreVersionsPlatform,
                filterAppStoreVersionsAppVersionState: filterAppStoreVersionsAppVersionState,
                filterReviewSubmissionsState: filterReviewSubmissionsState,
                filterReviewSubmissionsPlatform: filterReviewSubmissionsPlatform,
                filterAppStoreVersions: filterAppStoreVersions,
                filterId: filterId,
                existsGameCenterEnabledVersions: existsGameCenterEnabledVersions,
                sort: sort,
                fieldsApps: fieldsApps,
                fieldsAppEncryptionDeclarations: fieldsAppEncryptionDeclarations,
                fieldsBuildIcons: fieldsBuildIcons,
                fieldsCiProducts: fieldsCiProducts,
                fieldsBetaGroups: fieldsBetaGroups,
                fieldsAppStoreVersions: fieldsAppStoreVersions,
                fieldsPreReleaseVersions: fieldsPreReleaseVersions,
                fieldsBetaAppLocalizations: fieldsBetaAppLocalizations,
                fieldsBuilds: fieldsBuilds,
                fieldsBetaLicenseAgreements: fieldsBetaLicenseAgreements,
                fieldsBetaAppReviewDetails: fieldsBetaAppReviewDetails,
                fieldsAppInfos: fieldsAppInfos,
                fieldsAppClips: fieldsAppClips,
                fieldsEndUserLicenseAgreements: fieldsEndUserLicenseAgreements,
                fieldsInAppPurchases: fieldsInAppPurchases,
                fieldsSubscriptionGroups: fieldsSubscriptionGroups,
                fieldsGameCenterEnabledVersions: fieldsGameCenterEnabledVersions,
                fieldsAppCustomProductPages: fieldsAppCustomProductPages,
                fieldsPromotedPurchases: fieldsPromotedPurchases,
                fieldsAppEvents: fieldsAppEvents,
                fieldsReviewSubmissions: fieldsReviewSubmissions,
                fieldsSubscriptionGracePeriods: fieldsSubscriptionGracePeriods,
                fieldsGameCenterDetails: fieldsGameCenterDetails,
                fieldsAppStoreVersionExperiments: fieldsAppStoreVersionExperiments,
                fieldsAndroidToIosAppMappingDetails: fieldsAndroidToIosAppMappingDetails,
                limit: limit,
                include: include,
                limitAndroidToIosAppMappingDetails: limitAndroidToIosAppMappingDetails,
                limitAppClips: limitAppClips,
                limitAppCustomProductPages: limitAppCustomProductPages,
                limitAppEncryptionDeclarations: limitAppEncryptionDeclarations,
                limitAppEvents: limitAppEvents,
                limitAppInfos: limitAppInfos,
                limitAppStoreVersionExperimentsV2: limitAppStoreVersionExperimentsV2,
                limitAppStoreVersions: limitAppStoreVersions,
                limitBetaAppLocalizations: limitBetaAppLocalizations,
                limitBetaGroups: limitBetaGroups,
                limitBuilds: limitBuilds,
                limitGameCenterEnabledVersions: limitGameCenterEnabledVersions,
                limitInAppPurchases: limitInAppPurchases,
                limitInAppPurchasesV2: limitInAppPurchasesV2,
                limitPreReleaseVersions: limitPreReleaseVersions,
                limitPromotedPurchases: limitPromotedPurchases,
                limitReviewSubmissions: limitReviewSubmissions,
                limitSubscriptionGroups: limitSubscriptionGroups,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterBundleId"></param>
        /// <param name="filterSku"></param>
        /// <param name="filterAppStoreVersionsAppStoreState"></param>
        /// <param name="filterAppStoreVersionsPlatform"></param>
        /// <param name="filterAppStoreVersionsAppVersionState"></param>
        /// <param name="filterReviewSubmissionsState"></param>
        /// <param name="filterReviewSubmissionsPlatform"></param>
        /// <param name="filterAppStoreVersions"></param>
        /// <param name="filterId"></param>
        /// <param name="existsGameCenterEnabledVersions"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsBuildIcons"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBetaAppLocalizations"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaLicenseAgreements"></param>
        /// <param name="fieldsBetaAppReviewDetails"></param>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="fieldsAppClips"></param>
        /// <param name="fieldsEndUserLicenseAgreements"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsGameCenterEnabledVersions"></param>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsSubscriptionGracePeriods"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAndroidToIosAppMappingDetails"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAndroidToIosAppMappingDetails"></param>
        /// <param name="limitAppClips"></param>
        /// <param name="limitAppCustomProductPages"></param>
        /// <param name="limitAppEncryptionDeclarations"></param>
        /// <param name="limitAppEvents"></param>
        /// <param name="limitAppInfos"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="limitAppStoreVersions"></param>
        /// <param name="limitBetaAppLocalizations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="limitGameCenterEnabledVersions"></param>
        /// <param name="limitInAppPurchases"></param>
        /// <param name="limitInAppPurchasesV2"></param>
        /// <param name="limitPreReleaseVersions"></param>
        /// <param name="limitPromotedPurchases"></param>
        /// <param name="limitReviewSubmissions"></param>
        /// <param name="limitSubscriptionGroups"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppsResponse>> AppsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterBundleId = default,
            global::System.Collections.Generic.IList<string>? filterSku = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem>? filterAppStoreVersionsAppStoreState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem>? filterAppStoreVersionsPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem>? filterAppStoreVersionsAppVersionState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem>? filterReviewSubmissionsState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem>? filterReviewSubmissionsPlatform = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersions = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            bool? existsGameCenterEnabledVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization>? fieldsBetaAppLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionIncludeItem>? include = default,
            int? limitAndroidToIosAppMappingDetails = default,
            int? limitAppClips = default,
            int? limitAppCustomProductPages = default,
            int? limitAppEncryptionDeclarations = default,
            int? limitAppEvents = default,
            int? limitAppInfos = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            int? limitAppStoreVersions = default,
            int? limitBetaAppLocalizations = default,
            int? limitBetaGroups = default,
            int? limitBuilds = default,
            int? limitGameCenterEnabledVersions = default,
            int? limitInAppPurchases = default,
            int? limitInAppPurchasesV2 = default,
            int? limitPreReleaseVersions = default,
            int? limitPromotedPurchases = default,
            int? limitReviewSubmissions = default,
            int? limitSubscriptionGroups = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAppsGetCollectionArguments(
                httpClient: HttpClient,
                filterName: filterName,
                filterBundleId: filterBundleId,
                filterSku: filterSku,
                filterAppStoreVersionsAppStoreState: filterAppStoreVersionsAppStoreState,
                filterAppStoreVersionsPlatform: filterAppStoreVersionsPlatform,
                filterAppStoreVersionsAppVersionState: filterAppStoreVersionsAppVersionState,
                filterReviewSubmissionsState: filterReviewSubmissionsState,
                filterReviewSubmissionsPlatform: filterReviewSubmissionsPlatform,
                filterAppStoreVersions: filterAppStoreVersions,
                filterId: filterId,
                existsGameCenterEnabledVersions: ref existsGameCenterEnabledVersions,
                sort: sort,
                fieldsApps: fieldsApps,
                fieldsAppEncryptionDeclarations: fieldsAppEncryptionDeclarations,
                fieldsBuildIcons: fieldsBuildIcons,
                fieldsCiProducts: fieldsCiProducts,
                fieldsBetaGroups: fieldsBetaGroups,
                fieldsAppStoreVersions: fieldsAppStoreVersions,
                fieldsPreReleaseVersions: fieldsPreReleaseVersions,
                fieldsBetaAppLocalizations: fieldsBetaAppLocalizations,
                fieldsBuilds: fieldsBuilds,
                fieldsBetaLicenseAgreements: fieldsBetaLicenseAgreements,
                fieldsBetaAppReviewDetails: fieldsBetaAppReviewDetails,
                fieldsAppInfos: fieldsAppInfos,
                fieldsAppClips: fieldsAppClips,
                fieldsEndUserLicenseAgreements: fieldsEndUserLicenseAgreements,
                fieldsInAppPurchases: fieldsInAppPurchases,
                fieldsSubscriptionGroups: fieldsSubscriptionGroups,
                fieldsGameCenterEnabledVersions: fieldsGameCenterEnabledVersions,
                fieldsAppCustomProductPages: fieldsAppCustomProductPages,
                fieldsPromotedPurchases: fieldsPromotedPurchases,
                fieldsAppEvents: fieldsAppEvents,
                fieldsReviewSubmissions: fieldsReviewSubmissions,
                fieldsSubscriptionGracePeriods: fieldsSubscriptionGracePeriods,
                fieldsGameCenterDetails: fieldsGameCenterDetails,
                fieldsAppStoreVersionExperiments: fieldsAppStoreVersionExperiments,
                fieldsAndroidToIosAppMappingDetails: fieldsAndroidToIosAppMappingDetails,
                limit: ref limit,
                include: include,
                limitAndroidToIosAppMappingDetails: ref limitAndroidToIosAppMappingDetails,
                limitAppClips: ref limitAppClips,
                limitAppCustomProductPages: ref limitAppCustomProductPages,
                limitAppEncryptionDeclarations: ref limitAppEncryptionDeclarations,
                limitAppEvents: ref limitAppEvents,
                limitAppInfos: ref limitAppInfos,
                limitAppStoreVersionExperimentsV2: ref limitAppStoreVersionExperimentsV2,
                limitAppStoreVersions: ref limitAppStoreVersions,
                limitBetaAppLocalizations: ref limitBetaAppLocalizations,
                limitBetaGroups: ref limitBetaGroups,
                limitBuilds: ref limitBuilds,
                limitGameCenterEnabledVersions: ref limitGameCenterEnabledVersions,
                limitInAppPurchases: ref limitInAppPurchases,
                limitInAppPurchasesV2: ref limitInAppPurchasesV2,
                limitPreReleaseVersions: ref limitPreReleaseVersions,
                limitPromotedPurchases: ref limitPromotedPurchases,
                limitReviewSubmissions: ref limitReviewSubmissions,
                limitSubscriptionGroups: ref limitSubscriptionGroups);


            var __authorizations = global::AppStoreConnect.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AppsGetCollectionSecurityRequirements,
                operationName: "AppsGetCollectionAsync");

            using var __timeoutCancellationTokenSource = global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::AppStoreConnect.PathBuilder(
                                path: "/v1/apps",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("filter[name]", filterName, delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[bundleId]", filterBundleId, delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[sku]", filterSku, delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[appStoreVersions.appStoreState]", filterAppStoreVersionsAppStoreState, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[appStoreVersions.platform]", filterAppStoreVersionsPlatform, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[appStoreVersions.appVersionState]", filterAppStoreVersionsAppVersionState, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[reviewSubmissions.state]", filterReviewSubmissionsState, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[reviewSubmissions.platform]", filterReviewSubmissionsPlatform, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[appStoreVersions]", filterAppStoreVersions, delimiter: ",", explode: false)
                                .AddOptionalParameter("filter[id]", filterId, delimiter: ",", explode: false)
                                .AddOptionalParameter("exists[gameCenterEnabledVersions]", existsGameCenterEnabledVersions?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("sort", sort, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[apps]", fieldsApps, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appEncryptionDeclarations]", fieldsAppEncryptionDeclarations, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[buildIcons]", fieldsBuildIcons, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[ciProducts]", fieldsCiProducts, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaGroups]", fieldsBetaGroups, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appStoreVersions]", fieldsAppStoreVersions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[preReleaseVersions]", fieldsPreReleaseVersions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaAppLocalizations]", fieldsBetaAppLocalizations, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[builds]", fieldsBuilds, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaLicenseAgreements]", fieldsBetaLicenseAgreements, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaAppReviewDetails]", fieldsBetaAppReviewDetails, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appInfos]", fieldsAppInfos, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appClips]", fieldsAppClips, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[endUserLicenseAgreements]", fieldsEndUserLicenseAgreements, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[inAppPurchases]", fieldsInAppPurchases, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[subscriptionGroups]", fieldsSubscriptionGroups, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterEnabledVersions]", fieldsGameCenterEnabledVersions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appCustomProductPages]", fieldsAppCustomProductPages, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[promotedPurchases]", fieldsPromotedPurchases, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appEvents]", fieldsAppEvents, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[reviewSubmissions]", fieldsReviewSubmissions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[subscriptionGracePeriods]", fieldsSubscriptionGracePeriods, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterDetails]", fieldsGameCenterDetails, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appStoreVersionExperiments]", fieldsAppStoreVersionExperiments, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[androidToIosAppMappingDetails]", fieldsAndroidToIosAppMappingDetails, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("limit[androidToIosAppMappingDetails]", limitAndroidToIosAppMappingDetails?.ToString())
                                .AddOptionalParameter("limit[appClips]", limitAppClips?.ToString())
                                .AddOptionalParameter("limit[appCustomProductPages]", limitAppCustomProductPages?.ToString())
                                .AddOptionalParameter("limit[appEncryptionDeclarations]", limitAppEncryptionDeclarations?.ToString())
                                .AddOptionalParameter("limit[appEvents]", limitAppEvents?.ToString())
                                .AddOptionalParameter("limit[appInfos]", limitAppInfos?.ToString())
                                .AddOptionalParameter("limit[appStoreVersionExperimentsV2]", limitAppStoreVersionExperimentsV2?.ToString())
                                .AddOptionalParameter("limit[appStoreVersions]", limitAppStoreVersions?.ToString())
                                .AddOptionalParameter("limit[betaAppLocalizations]", limitBetaAppLocalizations?.ToString())
                                .AddOptionalParameter("limit[betaGroups]", limitBetaGroups?.ToString())
                                .AddOptionalParameter("limit[builds]", limitBuilds?.ToString())
                                .AddOptionalParameter("limit[gameCenterEnabledVersions]", limitGameCenterEnabledVersions?.ToString())
                                .AddOptionalParameter("limit[inAppPurchases]", limitInAppPurchases?.ToString())
                                .AddOptionalParameter("limit[inAppPurchasesV2]", limitInAppPurchasesV2?.ToString())
                                .AddOptionalParameter("limit[preReleaseVersions]", limitPreReleaseVersions?.ToString())
                                .AddOptionalParameter("limit[promotedPurchases]", limitPromotedPurchases?.ToString())
                                .AddOptionalParameter("limit[reviewSubmissions]", limitReviewSubmissions?.ToString())
                                .AddOptionalParameter("limit[subscriptionGroups]", limitSubscriptionGroups?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::AppStoreConnect.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                global::AppStoreConnect.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAppsGetCollectionRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    filterName: filterName,
                    filterBundleId: filterBundleId,
                    filterSku: filterSku,
                    filterAppStoreVersionsAppStoreState: filterAppStoreVersionsAppStoreState,
                    filterAppStoreVersionsPlatform: filterAppStoreVersionsPlatform,
                    filterAppStoreVersionsAppVersionState: filterAppStoreVersionsAppVersionState,
                    filterReviewSubmissionsState: filterReviewSubmissionsState,
                    filterReviewSubmissionsPlatform: filterReviewSubmissionsPlatform,
                    filterAppStoreVersions: filterAppStoreVersions,
                    filterId: filterId,
                    existsGameCenterEnabledVersions: existsGameCenterEnabledVersions,
                    sort: sort,
                    fieldsApps: fieldsApps,
                    fieldsAppEncryptionDeclarations: fieldsAppEncryptionDeclarations,
                    fieldsBuildIcons: fieldsBuildIcons,
                    fieldsCiProducts: fieldsCiProducts,
                    fieldsBetaGroups: fieldsBetaGroups,
                    fieldsAppStoreVersions: fieldsAppStoreVersions,
                    fieldsPreReleaseVersions: fieldsPreReleaseVersions,
                    fieldsBetaAppLocalizations: fieldsBetaAppLocalizations,
                    fieldsBuilds: fieldsBuilds,
                    fieldsBetaLicenseAgreements: fieldsBetaLicenseAgreements,
                    fieldsBetaAppReviewDetails: fieldsBetaAppReviewDetails,
                    fieldsAppInfos: fieldsAppInfos,
                    fieldsAppClips: fieldsAppClips,
                    fieldsEndUserLicenseAgreements: fieldsEndUserLicenseAgreements,
                    fieldsInAppPurchases: fieldsInAppPurchases,
                    fieldsSubscriptionGroups: fieldsSubscriptionGroups,
                    fieldsGameCenterEnabledVersions: fieldsGameCenterEnabledVersions,
                    fieldsAppCustomProductPages: fieldsAppCustomProductPages,
                    fieldsPromotedPurchases: fieldsPromotedPurchases,
                    fieldsAppEvents: fieldsAppEvents,
                    fieldsReviewSubmissions: fieldsReviewSubmissions,
                    fieldsSubscriptionGracePeriods: fieldsSubscriptionGracePeriods,
                    fieldsGameCenterDetails: fieldsGameCenterDetails,
                    fieldsAppStoreVersionExperiments: fieldsAppStoreVersionExperiments,
                    fieldsAndroidToIosAppMappingDetails: fieldsAndroidToIosAppMappingDetails,
                    limit: limit,
                    include: include,
                    limitAndroidToIosAppMappingDetails: limitAndroidToIosAppMappingDetails,
                    limitAppClips: limitAppClips,
                    limitAppCustomProductPages: limitAppCustomProductPages,
                    limitAppEncryptionDeclarations: limitAppEncryptionDeclarations,
                    limitAppEvents: limitAppEvents,
                    limitAppInfos: limitAppInfos,
                    limitAppStoreVersionExperimentsV2: limitAppStoreVersionExperimentsV2,
                    limitAppStoreVersions: limitAppStoreVersions,
                    limitBetaAppLocalizations: limitBetaAppLocalizations,
                    limitBetaGroups: limitBetaGroups,
                    limitBuilds: limitBuilds,
                    limitGameCenterEnabledVersions: limitGameCenterEnabledVersions,
                    limitInAppPurchases: limitInAppPurchases,
                    limitInAppPurchasesV2: limitInAppPurchasesV2,
                    limitPreReleaseVersions: limitPreReleaseVersions,
                    limitPromotedPurchases: limitPromotedPurchases,
                    limitReviewSubmissions: limitReviewSubmissions,
                    limitSubscriptionGroups: limitSubscriptionGroups);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AppsGetCollection",
                                methodName: "AppsGetCollectionAsync",
                                pathTemplate: "\"/v1/apps\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AppsGetCollection",
                                methodName: "AppsGetCollectionAsync",
                                pathTemplate: "\"/v1/apps\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::AppStoreConnect.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AppsGetCollection",
                                methodName: "AppsGetCollectionAsync",
                                pathTemplate: "\"/v1/apps\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessAppsGetCollectionResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AppsGetCollection",
                                methodName: "AppsGetCollectionAsync",
                                pathTemplate: "\"/v1/apps\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AppsGetCollection",
                                methodName: "AppsGetCollectionAsync",
                                pathTemplate: "\"/v1/apps\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Parameter error(s)
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::AppStoreConnect.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::AppStoreConnect.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::AppStoreConnect.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized error(s)
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::AppStoreConnect.ErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::AppStoreConnect.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::AppStoreConnect.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden error
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::AppStoreConnect.ErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::AppStoreConnect.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::AppStoreConnect.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Rate limit exceeded error
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::AppStoreConnect.ErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::AppStoreConnect.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::AppStoreConnect.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessAppsGetCollectionResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::AppStoreConnect.AppsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppsResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::AppStoreConnect.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::AppStoreConnect.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::AppStoreConnect.AppsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppsResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::AppStoreConnect.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::AppStoreConnect.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}