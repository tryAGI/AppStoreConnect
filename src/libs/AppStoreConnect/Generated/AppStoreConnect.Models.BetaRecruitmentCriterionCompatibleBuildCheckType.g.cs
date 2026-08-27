
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRecruitmentCriterionCompatibleBuildCheckType
    {
        /// <summary>
        ///
        /// </summary>
        BetaRecruitmentCriterionCompatibleBuildChecks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRecruitmentCriterionCompatibleBuildCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRecruitmentCriterionCompatibleBuildCheckType value)
        {
            return value switch
            {
                BetaRecruitmentCriterionCompatibleBuildCheckType.BetaRecruitmentCriterionCompatibleBuildChecks => "betaRecruitmentCriterionCompatibleBuildChecks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRecruitmentCriterionCompatibleBuildCheckType? ToEnum(string value)
        {
            return value switch
            {
                "betaRecruitmentCriterionCompatibleBuildChecks" => BetaRecruitmentCriterionCompatibleBuildCheckType.BetaRecruitmentCriterionCompatibleBuildChecks,
                _ => null,
            };
        }
    }
}