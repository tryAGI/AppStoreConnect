
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRecruitmentCriterionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaRecruitmentCriteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRecruitmentCriterionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRecruitmentCriterionCreateRequestDataType value)
        {
            return value switch
            {
                BetaRecruitmentCriterionCreateRequestDataType.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRecruitmentCriterionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaRecruitmentCriteria" => BetaRecruitmentCriterionCreateRequestDataType.BetaRecruitmentCriteria,
                _ => null,
            };
        }
    }
}