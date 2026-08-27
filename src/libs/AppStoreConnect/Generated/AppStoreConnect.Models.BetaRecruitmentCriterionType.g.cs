
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRecruitmentCriterionType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaRecruitmentCriteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRecruitmentCriterionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRecruitmentCriterionType value)
        {
            return value switch
            {
                BetaRecruitmentCriterionType.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRecruitmentCriterionType? ToEnum(string value)
        {
            return value switch
            {
                "betaRecruitmentCriteria" => BetaRecruitmentCriterionType.BetaRecruitmentCriteria,
                _ => null,
            };
        }
    }
}