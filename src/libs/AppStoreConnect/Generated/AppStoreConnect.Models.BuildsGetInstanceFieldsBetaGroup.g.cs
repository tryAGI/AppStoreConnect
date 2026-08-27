
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsBetaGroup
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
    public static class BuildsGetInstanceFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBetaGroup value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBetaGroup.App => "app",
                BuildsGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BuildsGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BuildsGetInstanceFieldsBetaGroup.BetaTesters => "betaTesters",
                BuildsGetInstanceFieldsBetaGroup.Builds => "builds",
                BuildsGetInstanceFieldsBetaGroup.CreatedDate => "createdDate",
                BuildsGetInstanceFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BuildsGetInstanceFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BuildsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BuildsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BuildsGetInstanceFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BuildsGetInstanceFieldsBetaGroup.Name => "name",
                BuildsGetInstanceFieldsBetaGroup.PublicLink => "publicLink",
                BuildsGetInstanceFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BuildsGetInstanceFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BuildsGetInstanceFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BuildsGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetInstanceFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BuildsGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BuildsGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BuildsGetInstanceFieldsBetaGroup.BetaTesters,
                "builds" => BuildsGetInstanceFieldsBetaGroup.Builds,
                "createdDate" => BuildsGetInstanceFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BuildsGetInstanceFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BuildsGetInstanceFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BuildsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BuildsGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BuildsGetInstanceFieldsBetaGroup.IsInternalGroup,
                "name" => BuildsGetInstanceFieldsBetaGroup.Name,
                "publicLink" => BuildsGetInstanceFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BuildsGetInstanceFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BuildsGetInstanceFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BuildsGetInstanceFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BuildsGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}