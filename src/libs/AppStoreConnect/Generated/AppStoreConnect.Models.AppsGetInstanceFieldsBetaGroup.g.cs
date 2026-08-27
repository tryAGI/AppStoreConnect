
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsBetaGroup
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
    public static class AppsGetInstanceFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsBetaGroup value)
        {
            return value switch
            {
                AppsGetInstanceFieldsBetaGroup.App => "app",
                AppsGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                AppsGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                AppsGetInstanceFieldsBetaGroup.BetaTesters => "betaTesters",
                AppsGetInstanceFieldsBetaGroup.Builds => "builds",
                AppsGetInstanceFieldsBetaGroup.CreatedDate => "createdDate",
                AppsGetInstanceFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                AppsGetInstanceFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                AppsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                AppsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                AppsGetInstanceFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                AppsGetInstanceFieldsBetaGroup.Name => "name",
                AppsGetInstanceFieldsBetaGroup.PublicLink => "publicLink",
                AppsGetInstanceFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                AppsGetInstanceFieldsBetaGroup.PublicLinkId => "publicLinkId",
                AppsGetInstanceFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                AppsGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => AppsGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => AppsGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => AppsGetInstanceFieldsBetaGroup.BetaTesters,
                "builds" => AppsGetInstanceFieldsBetaGroup.Builds,
                "createdDate" => AppsGetInstanceFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => AppsGetInstanceFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => AppsGetInstanceFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => AppsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => AppsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => AppsGetInstanceFieldsBetaGroup.IsInternalGroup,
                "name" => AppsGetInstanceFieldsBetaGroup.Name,
                "publicLink" => AppsGetInstanceFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => AppsGetInstanceFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => AppsGetInstanceFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => AppsGetInstanceFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => AppsGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}