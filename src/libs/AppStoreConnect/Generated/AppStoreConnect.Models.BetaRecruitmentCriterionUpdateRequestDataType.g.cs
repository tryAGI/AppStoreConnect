
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRecruitmentCriterionUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaRecruitmentCriteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRecruitmentCriterionUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRecruitmentCriterionUpdateRequestDataType value)
        {
            return value switch
            {
                BetaRecruitmentCriterionUpdateRequestDataType.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRecruitmentCriterionUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaRecruitmentCriteria" => BetaRecruitmentCriterionUpdateRequestDataType.BetaRecruitmentCriteria,
                _ => null,
            };
        }
    }
}