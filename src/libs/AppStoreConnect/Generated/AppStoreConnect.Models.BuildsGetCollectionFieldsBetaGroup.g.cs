
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsBetaGroup
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
    public static class BuildsGetCollectionFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBetaGroup value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBetaGroup.App => "app",
                BuildsGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BuildsGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BuildsGetCollectionFieldsBetaGroup.BetaTesters => "betaTesters",
                BuildsGetCollectionFieldsBetaGroup.Builds => "builds",
                BuildsGetCollectionFieldsBetaGroup.CreatedDate => "createdDate",
                BuildsGetCollectionFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BuildsGetCollectionFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BuildsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BuildsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BuildsGetCollectionFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BuildsGetCollectionFieldsBetaGroup.Name => "name",
                BuildsGetCollectionFieldsBetaGroup.PublicLink => "publicLink",
                BuildsGetCollectionFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BuildsGetCollectionFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BuildsGetCollectionFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BuildsGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetCollectionFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BuildsGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BuildsGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BuildsGetCollectionFieldsBetaGroup.BetaTesters,
                "builds" => BuildsGetCollectionFieldsBetaGroup.Builds,
                "createdDate" => BuildsGetCollectionFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BuildsGetCollectionFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BuildsGetCollectionFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BuildsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BuildsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BuildsGetCollectionFieldsBetaGroup.IsInternalGroup,
                "name" => BuildsGetCollectionFieldsBetaGroup.Name,
                "publicLink" => BuildsGetCollectionFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BuildsGetCollectionFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BuildsGetCollectionFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BuildsGetCollectionFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BuildsGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}