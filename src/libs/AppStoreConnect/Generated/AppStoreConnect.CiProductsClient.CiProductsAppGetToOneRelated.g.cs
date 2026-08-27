
#nullable enable

namespace AppStoreConnect
{
    public partial class CiProductsClient
    {


        private static readonly global::AppStoreConnect.EndPointSecurityRequirement s_CiProductsAppGetToOneRelatedSecurityRequirement0 =
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
        private static readonly global::AppStoreConnect.EndPointSecurityRequirement[] s_CiProductsAppGetToOneRelatedSecurityRequirements =
            new global::AppStoreConnect.EndPointSecurityRequirement[]
            {                s_CiProductsAppGetToOneRelatedSecurityRequirement0,
            };
        partial void PrepareCiProductsAppGetToOneRelatedArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>? fieldsCiProducts,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>? fieldsBetaAppLocalizations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>? fieldsBuilds,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>? fieldsAppInfos,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>? fieldsAppClips,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>? fieldsAppEvents,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>? fieldsReviewSubmissions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>? include,
            ref int? limitAppEncryptionDeclarations,
            ref int? limitBetaGroups,
            ref int? limitAppStoreVersions,
            ref int? limitPreReleaseVersions,
            ref int? limitBetaAppLocalizations,
            ref int? limitBuilds,
            ref int? limitAppInfos,
            ref int? limitAppClips,
            ref int? limitInAppPurchases,
            ref int? limitSubscriptionGroups,
            ref int? limitGameCenterEnabledVersions,
            ref int? limitAppCustomProductPages,
            ref int? limitInAppPurchasesV2,
            ref int? limitPromotedPurchases,
            ref int? limitAppEvents,
            ref int? limitReviewSubmissions,
            ref int? limitAppStoreVersionExperimentsV2,
            ref int? limitAndroidToIosAppMappingDetails,
            ref string id);
        partial void PrepareCiProductsAppGetToOneRelatedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>? fieldsCiProducts,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>? fieldsBetaAppLocalizations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>? fieldsBuilds,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>? fieldsAppInfos,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>? fieldsAppClips,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>? fieldsAppEvents,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>? fieldsReviewSubmissions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>? include,
            int? limitAppEncryptionDeclarations,
            int? limitBetaGroups,
            int? limitAppStoreVersions,
            int? limitPreReleaseVersions,
            int? limitBetaAppLocalizations,
            int? limitBuilds,
            int? limitAppInfos,
            int? limitAppClips,
            int? limitInAppPurchases,
            int? limitSubscriptionGroups,
            int? limitGameCenterEnabledVersions,
            int? limitAppCustomProductPages,
            int? limitInAppPurchasesV2,
            int? limitPromotedPurchases,
            int? limitAppEvents,
            int? limitReviewSubmissions,
            int? limitAppStoreVersionExperimentsV2,
            int? limitAndroidToIosAppMappingDetails,
            string id);
        partial void ProcessCiProductsAppGetToOneRelatedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCiProductsAppGetToOneRelatedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        ///
        /// </summary>
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
        /// <param name="include"></param>
        /// <param name="limitAppEncryptionDeclarations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitAppStoreVersions"></param>
        /// <param name="limitPreReleaseVersions"></param>
        /// <param name="limitBetaAppLocalizations"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="limitAppInfos"></param>
        /// <param name="limitAppClips"></param>
        /// <param name="limitInAppPurchases"></param>
        /// <param name="limitSubscriptionGroups"></param>
        /// <param name="limitGameCenterEnabledVersions"></param>
        /// <param name="limitAppCustomProductPages"></param>
        /// <param name="limitInAppPurchasesV2"></param>
        /// <param name="limitPromotedPurchases"></param>
        /// <param name="limitAppEvents"></param>
        /// <param name="limitReviewSubmissions"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="limitAndroidToIosAppMappingDetails"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.AppResponse> CiProductsAppGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>? fieldsBetaAppLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>? include = default,
            int? limitAppEncryptionDeclarations = default,
            int? limitBetaGroups = default,
            int? limitAppStoreVersions = default,
            int? limitPreReleaseVersions = default,
            int? limitBetaAppLocalizations = default,
            int? limitBuilds = default,
            int? limitAppInfos = default,
            int? limitAppClips = default,
            int? limitInAppPurchases = default,
            int? limitSubscriptionGroups = default,
            int? limitGameCenterEnabledVersions = default,
            int? limitAppCustomProductPages = default,
            int? limitInAppPurchasesV2 = default,
            int? limitPromotedPurchases = default,
            int? limitAppEvents = default,
            int? limitReviewSubmissions = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            int? limitAndroidToIosAppMappingDetails = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CiProductsAppGetToOneRelatedAsResponseAsync(
                id: id,
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
                include: include,
                limitAppEncryptionDeclarations: limitAppEncryptionDeclarations,
                limitBetaGroups: limitBetaGroups,
                limitAppStoreVersions: limitAppStoreVersions,
                limitPreReleaseVersions: limitPreReleaseVersions,
                limitBetaAppLocalizations: limitBetaAppLocalizations,
                limitBuilds: limitBuilds,
                limitAppInfos: limitAppInfos,
                limitAppClips: limitAppClips,
                limitInAppPurchases: limitInAppPurchases,
                limitSubscriptionGroups: limitSubscriptionGroups,
                limitGameCenterEnabledVersions: limitGameCenterEnabledVersions,
                limitAppCustomProductPages: limitAppCustomProductPages,
                limitInAppPurchasesV2: limitInAppPurchasesV2,
                limitPromotedPurchases: limitPromotedPurchases,
                limitAppEvents: limitAppEvents,
                limitReviewSubmissions: limitReviewSubmissions,
                limitAppStoreVersionExperimentsV2: limitAppStoreVersionExperimentsV2,
                limitAndroidToIosAppMappingDetails: limitAndroidToIosAppMappingDetails,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        ///
        /// </summary>
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
        /// <param name="include"></param>
        /// <param name="limitAppEncryptionDeclarations"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitAppStoreVersions"></param>
        /// <param name="limitPreReleaseVersions"></param>
        /// <param name="limitBetaAppLocalizations"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="limitAppInfos"></param>
        /// <param name="limitAppClips"></param>
        /// <param name="limitInAppPurchases"></param>
        /// <param name="limitSubscriptionGroups"></param>
        /// <param name="limitGameCenterEnabledVersions"></param>
        /// <param name="limitAppCustomProductPages"></param>
        /// <param name="limitInAppPurchasesV2"></param>
        /// <param name="limitPromotedPurchases"></param>
        /// <param name="limitAppEvents"></param>
        /// <param name="limitReviewSubmissions"></param>
        /// <param name="limitAppStoreVersionExperimentsV2"></param>
        /// <param name="limitAndroidToIosAppMappingDetails"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppResponse>> CiProductsAppGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>? fieldsBetaAppLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>? fieldsBetaLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>? fieldsAppClips = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>? fieldsEndUserLicenseAgreements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>? fieldsGameCenterEnabledVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>? fieldsSubscriptionGracePeriods = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>? fieldsAndroidToIosAppMappingDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>? include = default,
            int? limitAppEncryptionDeclarations = default,
            int? limitBetaGroups = default,
            int? limitAppStoreVersions = default,
            int? limitPreReleaseVersions = default,
            int? limitBetaAppLocalizations = default,
            int? limitBuilds = default,
            int? limitAppInfos = default,
            int? limitAppClips = default,
            int? limitInAppPurchases = default,
            int? limitSubscriptionGroups = default,
            int? limitGameCenterEnabledVersions = default,
            int? limitAppCustomProductPages = default,
            int? limitInAppPurchasesV2 = default,
            int? limitPromotedPurchases = default,
            int? limitAppEvents = default,
            int? limitReviewSubmissions = default,
            int? limitAppStoreVersionExperimentsV2 = default,
            int? limitAndroidToIosAppMappingDetails = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCiProductsAppGetToOneRelatedArguments(
                httpClient: HttpClient,
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
                include: include,
                limitAppEncryptionDeclarations: ref limitAppEncryptionDeclarations,
                limitBetaGroups: ref limitBetaGroups,
                limitAppStoreVersions: ref limitAppStoreVersions,
                limitPreReleaseVersions: ref limitPreReleaseVersions,
                limitBetaAppLocalizations: ref limitBetaAppLocalizations,
                limitBuilds: ref limitBuilds,
                limitAppInfos: ref limitAppInfos,
                limitAppClips: ref limitAppClips,
                limitInAppPurchases: ref limitInAppPurchases,
                limitSubscriptionGroups: ref limitSubscriptionGroups,
                limitGameCenterEnabledVersions: ref limitGameCenterEnabledVersions,
                limitAppCustomProductPages: ref limitAppCustomProductPages,
                limitInAppPurchasesV2: ref limitInAppPurchasesV2,
                limitPromotedPurchases: ref limitPromotedPurchases,
                limitAppEvents: ref limitAppEvents,
                limitReviewSubmissions: ref limitReviewSubmissions,
                limitAppStoreVersionExperimentsV2: ref limitAppStoreVersionExperimentsV2,
                limitAndroidToIosAppMappingDetails: ref limitAndroidToIosAppMappingDetails,
                id: ref id);


            var __authorizations = global::AppStoreConnect.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CiProductsAppGetToOneRelatedSecurityRequirements,
                operationName: "CiProductsAppGetToOneRelatedAsync");

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
                                path: $"/v1/ciProducts/{id}/app",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
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
                                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("limit[appEncryptionDeclarations]", limitAppEncryptionDeclarations?.ToString())
                                .AddOptionalParameter("limit[betaGroups]", limitBetaGroups?.ToString())
                                .AddOptionalParameter("limit[appStoreVersions]", limitAppStoreVersions?.ToString())
                                .AddOptionalParameter("limit[preReleaseVersions]", limitPreReleaseVersions?.ToString())
                                .AddOptionalParameter("limit[betaAppLocalizations]", limitBetaAppLocalizations?.ToString())
                                .AddOptionalParameter("limit[builds]", limitBuilds?.ToString())
                                .AddOptionalParameter("limit[appInfos]", limitAppInfos?.ToString())
                                .AddOptionalParameter("limit[appClips]", limitAppClips?.ToString())
                                .AddOptionalParameter("limit[inAppPurchases]", limitInAppPurchases?.ToString())
                                .AddOptionalParameter("limit[subscriptionGroups]", limitSubscriptionGroups?.ToString())
                                .AddOptionalParameter("limit[gameCenterEnabledVersions]", limitGameCenterEnabledVersions?.ToString())
                                .AddOptionalParameter("limit[appCustomProductPages]", limitAppCustomProductPages?.ToString())
                                .AddOptionalParameter("limit[inAppPurchasesV2]", limitInAppPurchasesV2?.ToString())
                                .AddOptionalParameter("limit[promotedPurchases]", limitPromotedPurchases?.ToString())
                                .AddOptionalParameter("limit[appEvents]", limitAppEvents?.ToString())
                                .AddOptionalParameter("limit[reviewSubmissions]", limitReviewSubmissions?.ToString())
                                .AddOptionalParameter("limit[appStoreVersionExperimentsV2]", limitAppStoreVersionExperimentsV2?.ToString())
                                .AddOptionalParameter("limit[androidToIosAppMappingDetails]", limitAndroidToIosAppMappingDetails?.ToString())
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
                PrepareCiProductsAppGetToOneRelatedRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                    include: include,
                    limitAppEncryptionDeclarations: limitAppEncryptionDeclarations,
                    limitBetaGroups: limitBetaGroups,
                    limitAppStoreVersions: limitAppStoreVersions,
                    limitPreReleaseVersions: limitPreReleaseVersions,
                    limitBetaAppLocalizations: limitBetaAppLocalizations,
                    limitBuilds: limitBuilds,
                    limitAppInfos: limitAppInfos,
                    limitAppClips: limitAppClips,
                    limitInAppPurchases: limitInAppPurchases,
                    limitSubscriptionGroups: limitSubscriptionGroups,
                    limitGameCenterEnabledVersions: limitGameCenterEnabledVersions,
                    limitAppCustomProductPages: limitAppCustomProductPages,
                    limitInAppPurchasesV2: limitInAppPurchasesV2,
                    limitPromotedPurchases: limitPromotedPurchases,
                    limitAppEvents: limitAppEvents,
                    limitReviewSubmissions: limitReviewSubmissions,
                    limitAppStoreVersionExperimentsV2: limitAppStoreVersionExperimentsV2,
                    limitAndroidToIosAppMappingDetails: limitAndroidToIosAppMappingDetails,
                    id: id!);

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
                                operationId: "CiProductsAppGetToOneRelated",
                                methodName: "CiProductsAppGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/ciProducts/{id}/app\"",
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
                                operationId: "CiProductsAppGetToOneRelated",
                                methodName: "CiProductsAppGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/ciProducts/{id}/app\"",
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
                                operationId: "CiProductsAppGetToOneRelated",
                                methodName: "CiProductsAppGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/ciProducts/{id}/app\"",
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
                ProcessCiProductsAppGetToOneRelatedResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CiProductsAppGetToOneRelated",
                                methodName: "CiProductsAppGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/ciProducts/{id}/app\"",
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
                                operationId: "CiProductsAppGetToOneRelated",
                                methodName: "CiProductsAppGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/ciProducts/{id}/app\"",
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
                            // Not found error
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::AppStoreConnect.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::AppStoreConnect.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::AppStoreConnect.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
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
                                ProcessCiProductsAppGetToOneRelatedResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::AppStoreConnect.AppResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppResponse>(
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

                                    var __value = await global::AppStoreConnect.AppResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppResponse>(
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