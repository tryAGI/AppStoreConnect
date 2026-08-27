
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.App => "app",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.BetaTesters => "betaTesters",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.Builds => "builds",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.CreatedDate => "createdDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.Name => "name",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLink => "publicLink",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkId => "publicLinkId",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.BetaTesters,
                "builds" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.Builds,
                "createdDate" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.IsInternalGroup,
                "name" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.Name,
                "publicLink" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}