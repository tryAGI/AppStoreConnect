
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsBetaGroup
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
    public static class AppsGetCollectionFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsBetaGroup value)
        {
            return value switch
            {
                AppsGetCollectionFieldsBetaGroup.App => "app",
                AppsGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                AppsGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                AppsGetCollectionFieldsBetaGroup.BetaTesters => "betaTesters",
                AppsGetCollectionFieldsBetaGroup.Builds => "builds",
                AppsGetCollectionFieldsBetaGroup.CreatedDate => "createdDate",
                AppsGetCollectionFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                AppsGetCollectionFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                AppsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                AppsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                AppsGetCollectionFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                AppsGetCollectionFieldsBetaGroup.Name => "name",
                AppsGetCollectionFieldsBetaGroup.PublicLink => "publicLink",
                AppsGetCollectionFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                AppsGetCollectionFieldsBetaGroup.PublicLinkId => "publicLinkId",
                AppsGetCollectionFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                AppsGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => AppsGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => AppsGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => AppsGetCollectionFieldsBetaGroup.BetaTesters,
                "builds" => AppsGetCollectionFieldsBetaGroup.Builds,
                "createdDate" => AppsGetCollectionFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => AppsGetCollectionFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => AppsGetCollectionFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => AppsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => AppsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => AppsGetCollectionFieldsBetaGroup.IsInternalGroup,
                "name" => AppsGetCollectionFieldsBetaGroup.Name,
                "publicLink" => AppsGetCollectionFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => AppsGetCollectionFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => AppsGetCollectionFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => AppsGetCollectionFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => AppsGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}