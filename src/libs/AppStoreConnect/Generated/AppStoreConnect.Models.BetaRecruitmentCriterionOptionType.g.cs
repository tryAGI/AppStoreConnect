
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRecruitmentCriterionOptionType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaRecruitmentCriterionOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRecruitmentCriterionOptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRecruitmentCriterionOptionType value)
        {
            return value switch
            {
                BetaRecruitmentCriterionOptionType.BetaRecruitmentCriterionOptions => "betaRecruitmentCriterionOptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRecruitmentCriterionOptionType? ToEnum(string value)
        {
            return value switch
            {
                "betaRecruitmentCriterionOptions" => BetaRecruitmentCriterionOptionType.BetaRecruitmentCriterionOptions,
                _ => null,
            };
        }
    }
}