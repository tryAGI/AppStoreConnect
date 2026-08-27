
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersGetCollectionFieldsBetaGroup
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
    public static class BetaTestersGetCollectionFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetCollectionFieldsBetaGroup value)
        {
            return value switch
            {
                BetaTestersGetCollectionFieldsBetaGroup.App => "app",
                BetaTestersGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaTestersGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BetaTestersGetCollectionFieldsBetaGroup.BetaTesters => "betaTesters",
                BetaTestersGetCollectionFieldsBetaGroup.Builds => "builds",
                BetaTestersGetCollectionFieldsBetaGroup.CreatedDate => "createdDate",
                BetaTestersGetCollectionFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BetaTestersGetCollectionFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BetaTestersGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BetaTestersGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BetaTestersGetCollectionFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BetaTestersGetCollectionFieldsBetaGroup.Name => "name",
                BetaTestersGetCollectionFieldsBetaGroup.PublicLink => "publicLink",
                BetaTestersGetCollectionFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BetaTestersGetCollectionFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BetaTestersGetCollectionFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BetaTestersGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetCollectionFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaTestersGetCollectionFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BetaTestersGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BetaTestersGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BetaTestersGetCollectionFieldsBetaGroup.BetaTesters,
                "builds" => BetaTestersGetCollectionFieldsBetaGroup.Builds,
                "createdDate" => BetaTestersGetCollectionFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BetaTestersGetCollectionFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BetaTestersGetCollectionFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BetaTestersGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BetaTestersGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BetaTestersGetCollectionFieldsBetaGroup.IsInternalGroup,
                "name" => BetaTestersGetCollectionFieldsBetaGroup.Name,
                "publicLink" => BetaTestersGetCollectionFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BetaTestersGetCollectionFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BetaTestersGetCollectionFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BetaTestersGetCollectionFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BetaTestersGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}