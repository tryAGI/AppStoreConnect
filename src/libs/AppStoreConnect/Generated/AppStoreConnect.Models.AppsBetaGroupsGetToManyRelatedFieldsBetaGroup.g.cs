
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaGroupsGetToManyRelatedFieldsBetaGroup
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        BetaRecruitmentCriteria,
        /// <summary>
        /// 
        /// </summary>
        BetaRecruitmentCriterionCompatibleBuildCheck,
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
        /// <summary>
        /// 
        /// </summary>
        Builds,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        FeedbackEnabled,
        /// <summary>
        /// 
        /// </summary>
        HasAccessToAllBuilds,
        /// <summary>
        /// 
        /// </summary>
        IosBuildsAvailableForAppleSiliconMac,
        /// <summary>
        /// 
        /// </summary>
        IosBuildsAvailableForAppleVision,
        /// <summary>
        /// 
        /// </summary>
        IsInternalGroup,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        PublicLink,
        /// <summary>
        /// 
        /// </summary>
        PublicLinkEnabled,
        /// <summary>
        /// 
        /// </summary>
        PublicLinkId,
        /// <summary>
        /// 
        /// </summary>
        PublicLinkLimit,
        /// <summary>
        /// 
        /// </summary>
        PublicLinkLimitEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBetaGroupsGetToManyRelatedFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaGroupsGetToManyRelatedFieldsBetaGroup value)
        {
            return value switch
            {
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.App => "app",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaTesters => "betaTesters",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.Builds => "builds",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.CreatedDate => "createdDate",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.Name => "name",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLink => "publicLink",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkId => "publicLinkId",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaGroupsGetToManyRelatedFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaTesters,
                "builds" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.Builds,
                "createdDate" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.IsInternalGroup,
                "name" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.Name,
                "publicLink" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => AppsBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}