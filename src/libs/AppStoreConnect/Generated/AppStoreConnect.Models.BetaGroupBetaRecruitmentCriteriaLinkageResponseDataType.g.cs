
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupBetaRecruitmentCriteriaLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaRecruitmentCriteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupBetaRecruitmentCriteriaLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupBetaRecruitmentCriteriaLinkageResponseDataType value)
        {
            return value switch
            {
                BetaGroupBetaRecruitmentCriteriaLinkageResponseDataType.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupBetaRecruitmentCriteriaLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaRecruitmentCriteria" => BetaGroupBetaRecruitmentCriteriaLinkageResponseDataType.BetaRecruitmentCriteria,
                _ => null,
            };
        }
    }
}