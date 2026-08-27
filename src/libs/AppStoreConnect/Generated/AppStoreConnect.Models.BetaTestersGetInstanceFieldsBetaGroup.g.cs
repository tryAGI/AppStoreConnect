
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersGetInstanceFieldsBetaGroup
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
    public static class BetaTestersGetInstanceFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetInstanceFieldsBetaGroup value)
        {
            return value switch
            {
                BetaTestersGetInstanceFieldsBetaGroup.App => "app",
                BetaTestersGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaTestersGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BetaTestersGetInstanceFieldsBetaGroup.BetaTesters => "betaTesters",
                BetaTestersGetInstanceFieldsBetaGroup.Builds => "builds",
                BetaTestersGetInstanceFieldsBetaGroup.CreatedDate => "createdDate",
                BetaTestersGetInstanceFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BetaTestersGetInstanceFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BetaTestersGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BetaTestersGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BetaTestersGetInstanceFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BetaTestersGetInstanceFieldsBetaGroup.Name => "name",
                BetaTestersGetInstanceFieldsBetaGroup.PublicLink => "publicLink",
                BetaTestersGetInstanceFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BetaTestersGetInstanceFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BetaTestersGetInstanceFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BetaTestersGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetInstanceFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaTestersGetInstanceFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BetaTestersGetInstanceFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BetaTestersGetInstanceFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BetaTestersGetInstanceFieldsBetaGroup.BetaTesters,
                "builds" => BetaTestersGetInstanceFieldsBetaGroup.Builds,
                "createdDate" => BetaTestersGetInstanceFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BetaTestersGetInstanceFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BetaTestersGetInstanceFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BetaTestersGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BetaTestersGetInstanceFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BetaTestersGetInstanceFieldsBetaGroup.IsInternalGroup,
                "name" => BetaTestersGetInstanceFieldsBetaGroup.Name,
                "publicLink" => BetaTestersGetInstanceFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BetaTestersGetInstanceFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BetaTestersGetInstanceFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BetaTestersGetInstanceFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BetaTestersGetInstanceFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}