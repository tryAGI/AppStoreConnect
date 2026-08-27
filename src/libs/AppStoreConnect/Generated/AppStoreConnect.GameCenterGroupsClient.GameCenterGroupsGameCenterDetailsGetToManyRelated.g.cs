
#nullable enable

namespace AppStoreConnect
{
    public partial class GameCenterGroupsClient
    {


        private static readonly global::AppStoreConnect.EndPointSecurityRequirement s_GameCenterGroupsGameCenterDetailsGetToManyRelatedSecurityRequirement0 =
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
        private static readonly global::AppStoreConnect.EndPointSecurityRequirement[] s_GameCenterGroupsGameCenterDetailsGetToManyRelatedSecurityRequirements =
            new global::AppStoreConnect.EndPointSecurityRequirement[]
            {                s_GameCenterGroupsGameCenterDetailsGetToManyRelatedSecurityRequirement0,
            };
        partial void PrepareGameCenterGroupsGameCenterDetailsGetToManyRelatedArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? filterGameCenterAppVersionsEnabled,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions,
            ref int? limit,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>? include,
            ref int? limitGameCenterAppVersions,
            ref int? limitGameCenterLeaderboards,
            ref int? limitGameCenterLeaderboardsV2,
            ref int? limitGameCenterLeaderboardSets,
            ref int? limitGameCenterLeaderboardSetsV2,
            ref int? limitGameCenterAchievements,
            ref int? limitGameCenterAchievementsV2,
            ref int? limitGameCenterActivities,
            ref int? limitGameCenterChallenges,
            ref int? limitAchievementReleases,
            ref int? limitActivityReleases,
            ref int? limitChallengeReleases,
            ref int? limitLeaderboardReleases,
            ref int? limitLeaderboardSetReleases,
            ref int? limitChallengesMinimumPlatformVersions,
            ref string id);
        partial void PrepareGameCenterGroupsGameCenterDetailsGetToManyRelatedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? filterGameCenterAppVersionsEnabled,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions,
            int? limit,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>? include,
            int? limitGameCenterAppVersions,
            int? limitGameCenterLeaderboards,
            int? limitGameCenterLeaderboardsV2,
            int? limitGameCenterLeaderboardSets,
            int? limitGameCenterLeaderboardSetsV2,
            int? limitGameCenterAchievements,
            int? limitGameCenterAchievementsV2,
            int? limitGameCenterActivities,
            int? limitGameCenterChallenges,
            int? limitAchievementReleases,
            int? limitActivityReleases,
            int? limitChallengeReleases,
            int? limitLeaderboardReleases,
            int? limitLeaderboardSetReleases,
            int? limitChallengesMinimumPlatformVersions,
            string id);
        partial void ProcessGameCenterGroupsGameCenterDetailsGetToManyRelatedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGameCenterGroupsGameCenterDetailsGetToManyRelatedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGameCenterAppVersionsEnabled"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterAchievementReleases"></param>
        /// <param name="fieldsGameCenterActivityVersionReleases"></param>
        /// <param name="fieldsGameCenterChallengeVersionReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardSetReleases"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterAppVersions"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitAchievementReleases"></param>
        /// <param name="limitActivityReleases"></param>
        /// <param name="limitChallengeReleases"></param>
        /// <param name="limitLeaderboardReleases"></param>
        /// <param name="limitLeaderboardSetReleases"></param>
        /// <param name="limitChallengesMinimumPlatformVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterDetailsResponse> GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterGameCenterAppVersionsEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>? include = default,
            int? limitGameCenterAppVersions = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterChallenges = default,
            int? limitAchievementReleases = default,
            int? limitActivityReleases = default,
            int? limitChallengeReleases = default,
            int? limitLeaderboardReleases = default,
            int? limitLeaderboardSetReleases = default,
            int? limitChallengesMinimumPlatformVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GameCenterGroupsGameCenterDetailsGetToManyRelatedAsResponseAsync(
                id: id,
                filterGameCenterAppVersionsEnabled: filterGameCenterAppVersionsEnabled,
                fieldsGameCenterDetails: fieldsGameCenterDetails,
                fieldsApps: fieldsApps,
                fieldsGameCenterAppVersions: fieldsGameCenterAppVersions,
                fieldsGameCenterGroups: fieldsGameCenterGroups,
                fieldsGameCenterLeaderboards: fieldsGameCenterLeaderboards,
                fieldsGameCenterLeaderboardSets: fieldsGameCenterLeaderboardSets,
                fieldsGameCenterAchievements: fieldsGameCenterAchievements,
                fieldsGameCenterActivities: fieldsGameCenterActivities,
                fieldsGameCenterChallenges: fieldsGameCenterChallenges,
                fieldsGameCenterAchievementReleases: fieldsGameCenterAchievementReleases,
                fieldsGameCenterActivityVersionReleases: fieldsGameCenterActivityVersionReleases,
                fieldsGameCenterChallengeVersionReleases: fieldsGameCenterChallengeVersionReleases,
                fieldsGameCenterLeaderboardReleases: fieldsGameCenterLeaderboardReleases,
                fieldsGameCenterLeaderboardSetReleases: fieldsGameCenterLeaderboardSetReleases,
                fieldsAppStoreVersions: fieldsAppStoreVersions,
                limit: limit,
                include: include,
                limitGameCenterAppVersions: limitGameCenterAppVersions,
                limitGameCenterLeaderboards: limitGameCenterLeaderboards,
                limitGameCenterLeaderboardsV2: limitGameCenterLeaderboardsV2,
                limitGameCenterLeaderboardSets: limitGameCenterLeaderboardSets,
                limitGameCenterLeaderboardSetsV2: limitGameCenterLeaderboardSetsV2,
                limitGameCenterAchievements: limitGameCenterAchievements,
                limitGameCenterAchievementsV2: limitGameCenterAchievementsV2,
                limitGameCenterActivities: limitGameCenterActivities,
                limitGameCenterChallenges: limitGameCenterChallenges,
                limitAchievementReleases: limitAchievementReleases,
                limitActivityReleases: limitActivityReleases,
                limitChallengeReleases: limitChallengeReleases,
                limitLeaderboardReleases: limitLeaderboardReleases,
                limitLeaderboardSetReleases: limitLeaderboardSetReleases,
                limitChallengesMinimumPlatformVersions: limitChallengesMinimumPlatformVersions,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGameCenterAppVersionsEnabled"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterAchievementReleases"></param>
        /// <param name="fieldsGameCenterActivityVersionReleases"></param>
        /// <param name="fieldsGameCenterChallengeVersionReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardSetReleases"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterAppVersions"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitAchievementReleases"></param>
        /// <param name="limitActivityReleases"></param>
        /// <param name="limitChallengeReleases"></param>
        /// <param name="limitLeaderboardReleases"></param>
        /// <param name="limitLeaderboardSetReleases"></param>
        /// <param name="limitChallengesMinimumPlatformVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterDetailsResponse>> GameCenterGroupsGameCenterDetailsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterGameCenterAppVersionsEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>? include = default,
            int? limitGameCenterAppVersions = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterChallenges = default,
            int? limitAchievementReleases = default,
            int? limitActivityReleases = default,
            int? limitChallengeReleases = default,
            int? limitLeaderboardReleases = default,
            int? limitLeaderboardSetReleases = default,
            int? limitChallengesMinimumPlatformVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGameCenterGroupsGameCenterDetailsGetToManyRelatedArguments(
                httpClient: HttpClient,
                filterGameCenterAppVersionsEnabled: filterGameCenterAppVersionsEnabled,
                fieldsGameCenterDetails: fieldsGameCenterDetails,
                fieldsApps: fieldsApps,
                fieldsGameCenterAppVersions: fieldsGameCenterAppVersions,
                fieldsGameCenterGroups: fieldsGameCenterGroups,
                fieldsGameCenterLeaderboards: fieldsGameCenterLeaderboards,
                fieldsGameCenterLeaderboardSets: fieldsGameCenterLeaderboardSets,
                fieldsGameCenterAchievements: fieldsGameCenterAchievements,
                fieldsGameCenterActivities: fieldsGameCenterActivities,
                fieldsGameCenterChallenges: fieldsGameCenterChallenges,
                fieldsGameCenterAchievementReleases: fieldsGameCenterAchievementReleases,
                fieldsGameCenterActivityVersionReleases: fieldsGameCenterActivityVersionReleases,
                fieldsGameCenterChallengeVersionReleases: fieldsGameCenterChallengeVersionReleases,
                fieldsGameCenterLeaderboardReleases: fieldsGameCenterLeaderboardReleases,
                fieldsGameCenterLeaderboardSetReleases: fieldsGameCenterLeaderboardSetReleases,
                fieldsAppStoreVersions: fieldsAppStoreVersions,
                limit: ref limit,
                include: include,
                limitGameCenterAppVersions: ref limitGameCenterAppVersions,
                limitGameCenterLeaderboards: ref limitGameCenterLeaderboards,
                limitGameCenterLeaderboardsV2: ref limitGameCenterLeaderboardsV2,
                limitGameCenterLeaderboardSets: ref limitGameCenterLeaderboardSets,
                limitGameCenterLeaderboardSetsV2: ref limitGameCenterLeaderboardSetsV2,
                limitGameCenterAchievements: ref limitGameCenterAchievements,
                limitGameCenterAchievementsV2: ref limitGameCenterAchievementsV2,
                limitGameCenterActivities: ref limitGameCenterActivities,
                limitGameCenterChallenges: ref limitGameCenterChallenges,
                limitAchievementReleases: ref limitAchievementReleases,
                limitActivityReleases: ref limitActivityReleases,
                limitChallengeReleases: ref limitChallengeReleases,
                limitLeaderboardReleases: ref limitLeaderboardReleases,
                limitLeaderboardSetReleases: ref limitLeaderboardSetReleases,
                limitChallengesMinimumPlatformVersions: ref limitChallengesMinimumPlatformVersions,
                id: ref id);


            var __authorizations = global::AppStoreConnect.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GameCenterGroupsGameCenterDetailsGetToManyRelatedSecurityRequirements,
                operationName: "GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync");

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
                                path: $"/v1/gameCenterGroups/{id}/gameCenterDetails",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("filter[gameCenterAppVersions.enabled]", filterGameCenterAppVersionsEnabled, delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterDetails]", fieldsGameCenterDetails, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[apps]", fieldsApps, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterAppVersions]", fieldsGameCenterAppVersions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterGroups]", fieldsGameCenterGroups, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterLeaderboards]", fieldsGameCenterLeaderboards, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterLeaderboardSets]", fieldsGameCenterLeaderboardSets, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterAchievements]", fieldsGameCenterAchievements, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterActivities]", fieldsGameCenterActivities, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterChallenges]", fieldsGameCenterChallenges, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterAchievementReleases]", fieldsGameCenterAchievementReleases, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterActivityVersionReleases]", fieldsGameCenterActivityVersionReleases, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterChallengeVersionReleases]", fieldsGameCenterChallengeVersionReleases, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterLeaderboardReleases]", fieldsGameCenterLeaderboardReleases, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[gameCenterLeaderboardSetReleases]", fieldsGameCenterLeaderboardSetReleases, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appStoreVersions]", fieldsAppStoreVersions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("limit[gameCenterAppVersions]", limitGameCenterAppVersions?.ToString())
                                .AddOptionalParameter("limit[gameCenterLeaderboards]", limitGameCenterLeaderboards?.ToString())
                                .AddOptionalParameter("limit[gameCenterLeaderboardsV2]", limitGameCenterLeaderboardsV2?.ToString())
                                .AddOptionalParameter("limit[gameCenterLeaderboardSets]", limitGameCenterLeaderboardSets?.ToString())
                                .AddOptionalParameter("limit[gameCenterLeaderboardSetsV2]", limitGameCenterLeaderboardSetsV2?.ToString())
                                .AddOptionalParameter("limit[gameCenterAchievements]", limitGameCenterAchievements?.ToString())
                                .AddOptionalParameter("limit[gameCenterAchievementsV2]", limitGameCenterAchievementsV2?.ToString())
                                .AddOptionalParameter("limit[gameCenterActivities]", limitGameCenterActivities?.ToString())
                                .AddOptionalParameter("limit[gameCenterChallenges]", limitGameCenterChallenges?.ToString())
                                .AddOptionalParameter("limit[achievementReleases]", limitAchievementReleases?.ToString())
                                .AddOptionalParameter("limit[activityReleases]", limitActivityReleases?.ToString())
                                .AddOptionalParameter("limit[challengeReleases]", limitChallengeReleases?.ToString())
                                .AddOptionalParameter("limit[leaderboardReleases]", limitLeaderboardReleases?.ToString())
                                .AddOptionalParameter("limit[leaderboardSetReleases]", limitLeaderboardSetReleases?.ToString())
                                .AddOptionalParameter("limit[challengesMinimumPlatformVersions]", limitChallengesMinimumPlatformVersions?.ToString())
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
                PrepareGameCenterGroupsGameCenterDetailsGetToManyRelatedRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    filterGameCenterAppVersionsEnabled: filterGameCenterAppVersionsEnabled,
                    fieldsGameCenterDetails: fieldsGameCenterDetails,
                    fieldsApps: fieldsApps,
                    fieldsGameCenterAppVersions: fieldsGameCenterAppVersions,
                    fieldsGameCenterGroups: fieldsGameCenterGroups,
                    fieldsGameCenterLeaderboards: fieldsGameCenterLeaderboards,
                    fieldsGameCenterLeaderboardSets: fieldsGameCenterLeaderboardSets,
                    fieldsGameCenterAchievements: fieldsGameCenterAchievements,
                    fieldsGameCenterActivities: fieldsGameCenterActivities,
                    fieldsGameCenterChallenges: fieldsGameCenterChallenges,
                    fieldsGameCenterAchievementReleases: fieldsGameCenterAchievementReleases,
                    fieldsGameCenterActivityVersionReleases: fieldsGameCenterActivityVersionReleases,
                    fieldsGameCenterChallengeVersionReleases: fieldsGameCenterChallengeVersionReleases,
                    fieldsGameCenterLeaderboardReleases: fieldsGameCenterLeaderboardReleases,
                    fieldsGameCenterLeaderboardSetReleases: fieldsGameCenterLeaderboardSetReleases,
                    fieldsAppStoreVersions: fieldsAppStoreVersions,
                    limit: limit,
                    include: include,
                    limitGameCenterAppVersions: limitGameCenterAppVersions,
                    limitGameCenterLeaderboards: limitGameCenterLeaderboards,
                    limitGameCenterLeaderboardsV2: limitGameCenterLeaderboardsV2,
                    limitGameCenterLeaderboardSets: limitGameCenterLeaderboardSets,
                    limitGameCenterLeaderboardSetsV2: limitGameCenterLeaderboardSetsV2,
                    limitGameCenterAchievements: limitGameCenterAchievements,
                    limitGameCenterAchievementsV2: limitGameCenterAchievementsV2,
                    limitGameCenterActivities: limitGameCenterActivities,
                    limitGameCenterChallenges: limitGameCenterChallenges,
                    limitAchievementReleases: limitAchievementReleases,
                    limitActivityReleases: limitActivityReleases,
                    limitChallengeReleases: limitChallengeReleases,
                    limitLeaderboardReleases: limitLeaderboardReleases,
                    limitLeaderboardSetReleases: limitLeaderboardSetReleases,
                    limitChallengesMinimumPlatformVersions: limitChallengesMinimumPlatformVersions,
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
                                operationId: "GameCenterGroupsGameCenterDetailsGetToManyRelated",
                                methodName: "GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync",
                                pathTemplate: "$\"/v1/gameCenterGroups/{id}/gameCenterDetails\"",
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
                                operationId: "GameCenterGroupsGameCenterDetailsGetToManyRelated",
                                methodName: "GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync",
                                pathTemplate: "$\"/v1/gameCenterGroups/{id}/gameCenterDetails\"",
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
                                operationId: "GameCenterGroupsGameCenterDetailsGetToManyRelated",
                                methodName: "GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync",
                                pathTemplate: "$\"/v1/gameCenterGroups/{id}/gameCenterDetails\"",
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
                ProcessGameCenterGroupsGameCenterDetailsGetToManyRelatedResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GameCenterGroupsGameCenterDetailsGetToManyRelated",
                                methodName: "GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync",
                                pathTemplate: "$\"/v1/gameCenterGroups/{id}/gameCenterDetails\"",
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
                                operationId: "GameCenterGroupsGameCenterDetailsGetToManyRelated",
                                methodName: "GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync",
                                pathTemplate: "$\"/v1/gameCenterGroups/{id}/gameCenterDetails\"",
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
                                ProcessGameCenterGroupsGameCenterDetailsGetToManyRelatedResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::AppStoreConnect.GameCenterDetailsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterDetailsResponse>(
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

                                    var __value = await global::AppStoreConnect.GameCenterDetailsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterDetailsResponse>(
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