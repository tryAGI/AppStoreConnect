
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsBetaRecruitmentCriterionCompatibleBuildCheckGetToOneRelatedFieldsBetaRecruitmentCriterionCompatibleBuildCheck
    {
        /// <summary>
        ///
        /// </summary>
        HasCompatibleBuild,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupsBetaRecruitmentCriterionCompatibleBuildCheckGetToOneRelatedFieldsBetaRecruitmentCriterionCompatibleBuildCheckExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsBetaRecruitmentCriterionCompatibleBuildCheckGetToOneRelatedFieldsBetaRecruitmentCriterionCompatibleBuildCheck value)
        {
            return value switch
            {
                BetaGroupsBetaRecruitmentCriterionCompatibleBuildCheckGetToOneRelatedFieldsBetaRecruitmentCriterionCompatibleBuildCheck.HasCompatibleBuild => "hasCompatibleBuild",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsBetaRecruitmentCriterionCompatibleBuildCheckGetToOneRelatedFieldsBetaRecruitmentCriterionCompatibleBuildCheck? ToEnum(string value)
        {
            return value switch
            {
                "hasCompatibleBuild" => BetaGroupsBetaRecruitmentCriterionCompatibleBuildCheckGetToOneRelatedFieldsBetaRecruitmentCriterionCompatibleBuildCheck.HasCompatibleBuild,
                _ => null,
            };
        }
    }
}