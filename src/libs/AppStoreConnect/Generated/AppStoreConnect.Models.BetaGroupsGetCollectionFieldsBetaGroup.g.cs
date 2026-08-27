
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetCollectionFieldsBetaGroup
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
    public static class BetaGroupsGetCollectionFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetCollectionFieldsBetaGroup value)
        {
            return value switch
            {
                BetaGroupsGetCollectionFieldsBetaGroup.App => "app",
                BetaGroupsGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaGroupsGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BetaGroupsGetCollectionFieldsBetaGroup.BetaTesters => "betaTesters",
                BetaGroupsGetCollectionFieldsBetaGroup.Builds => "builds",
                BetaGroupsGetCollectionFieldsBetaGroup.CreatedDate => "createdDate",
                BetaGroupsGetCollectionFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BetaGroupsGetCollectionFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BetaGroupsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BetaGroupsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BetaGroupsGetCollectionFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BetaGroupsGetCollectionFieldsBetaGroup.Name => "name",
                BetaGroupsGetCollectionFieldsBetaGroup.PublicLink => "publicLink",
                BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetCollectionFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaGroupsGetCollectionFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BetaGroupsGetCollectionFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BetaGroupsGetCollectionFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BetaGroupsGetCollectionFieldsBetaGroup.BetaTesters,
                "builds" => BetaGroupsGetCollectionFieldsBetaGroup.Builds,
                "createdDate" => BetaGroupsGetCollectionFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BetaGroupsGetCollectionFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BetaGroupsGetCollectionFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BetaGroupsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BetaGroupsGetCollectionFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BetaGroupsGetCollectionFieldsBetaGroup.IsInternalGroup,
                "name" => BetaGroupsGetCollectionFieldsBetaGroup.Name,
                "publicLink" => BetaGroupsGetCollectionFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BetaGroupsGetCollectionFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}