
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.App => "app",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.BetaTesters => "betaTesters",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.Builds => "builds",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.CreatedDate => "createdDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.Name => "name",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLink => "publicLink",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.BetaTesters,
                "builds" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.Builds,
                "createdDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.IsInternalGroup,
                "name" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.Name,
                "publicLink" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}