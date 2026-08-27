
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup
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
    public static class BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup value)
        {
            return value switch
            {
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.App => "app",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck => "betaRecruitmentCriterionCompatibleBuildCheck",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaTesters => "betaTesters",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.Builds => "builds",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.CreatedDate => "createdDate",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.FeedbackEnabled => "feedbackEnabled",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.HasAccessToAllBuilds => "hasAccessToAllBuilds",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac => "iosBuildsAvailableForAppleSiliconMac",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision => "iosBuildsAvailableForAppleVision",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.IsInternalGroup => "isInternalGroup",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.Name => "name",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLink => "publicLink",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkEnabled => "publicLinkEnabled",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkId => "publicLinkId",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimit => "publicLinkLimit",
                BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimitEnabled => "publicLinkLimitEnabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.App,
                "betaRecruitmentCriteria" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriteria,
                "betaRecruitmentCriterionCompatibleBuildCheck" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaRecruitmentCriterionCompatibleBuildCheck,
                "betaTesters" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.BetaTesters,
                "builds" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.Builds,
                "createdDate" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.CreatedDate,
                "feedbackEnabled" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.FeedbackEnabled,
                "hasAccessToAllBuilds" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.HasAccessToAllBuilds,
                "iosBuildsAvailableForAppleSiliconMac" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleSiliconMac,
                "iosBuildsAvailableForAppleVision" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.IosBuildsAvailableForAppleVision,
                "isInternalGroup" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.IsInternalGroup,
                "name" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.Name,
                "publicLink" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLink,
                "publicLinkEnabled" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkEnabled,
                "publicLinkId" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkId,
                "publicLinkLimit" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimit,
                "publicLinkLimitEnabled" => BetaTestersBetaGroupsGetToManyRelatedFieldsBetaGroup.PublicLinkLimitEnabled,
                _ => null,
            };
        }
    }
}