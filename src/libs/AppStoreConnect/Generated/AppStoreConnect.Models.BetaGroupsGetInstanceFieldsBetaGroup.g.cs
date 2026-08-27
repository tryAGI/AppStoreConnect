
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupsGetInstanceFieldsBetaGroup
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
    public static class BetaGroupsGetInstanceFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetInstanceFieldsBetaGroup value)
        {
            return value switch
            {
                BetaGroupsGetInstanceFieldsBetaGroup.App => "app",
                BetaGroupsGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaGroupsGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BetaGroupsGetInstanceFieldsBetaGroup.BetaTesters => "betaTesters",
                BetaGroupsGetInstanceFieldsBetaGroup.Builds => "builds",
                BetaGroupsGetInstanceFieldsBetaGroup.CreatedDate => "createdDate",
                BetaGroupsGetInstanceFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BetaGroupsGetInstanceFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BetaGroupsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BetaGroupsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BetaGroupsGetInstanceFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BetaGroupsGetInstanceFieldsBetaGroup.Name => "name",
                BetaGroupsGetInstanceFieldsBetaGroup.PublicLink => "publicLink",
                BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetInstanceFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaGroupsGetInstanceFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BetaGroupsGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BetaGroupsGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BetaGroupsGetInstanceFieldsBetaGroup.BetaTesters,
                "builds" => BetaGroupsGetInstanceFieldsBetaGroup.Builds,
                "createdDate" => BetaGroupsGetInstanceFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BetaGroupsGetInstanceFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BetaGroupsGetInstanceFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BetaGroupsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BetaGroupsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BetaGroupsGetInstanceFieldsBetaGroup.IsInternalGroup,
                "name" => BetaGroupsGetInstanceFieldsBetaGroup.Name,
                "publicLink" => BetaGroupsGetInstanceFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BetaGroupsGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}