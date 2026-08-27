
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsBetaGroup
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
    public static class CiProductsAppGetToOneRelatedFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsBetaGroup value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsBetaGroup.App => "app",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.BetaTesters => "betaTesters",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.Builds => "builds",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.CreatedDate => "createdDate",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.Name => "name",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLink => "publicLink",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkId => "publicLinkId",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => CiProductsAppGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => CiProductsAppGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => CiProductsAppGetToOneRelatedFieldsBetaGroup.BetaTesters,
                "builds" => CiProductsAppGetToOneRelatedFieldsBetaGroup.Builds,
                "createdDate" => CiProductsAppGetToOneRelatedFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => CiProductsAppGetToOneRelatedFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => CiProductsAppGetToOneRelatedFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => CiProductsAppGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => CiProductsAppGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => CiProductsAppGetToOneRelatedFieldsBetaGroup.IsInternalGroup,
                "name" => CiProductsAppGetToOneRelatedFieldsBetaGroup.Name,
                "publicLink" => CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => CiProductsAppGetToOneRelatedFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}