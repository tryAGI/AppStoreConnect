
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupRelationshipsBetaRecruitmentCriteriaDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaRecruitmentCriteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupRelationshipsBetaRecruitmentCriteriaDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupRelationshipsBetaRecruitmentCriteriaDataType value)
        {
            return value switch
            {
                BetaGroupRelationshipsBetaRecruitmentCriteriaDataType.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupRelationshipsBetaRecruitmentCriteriaDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaRecruitmentCriteria" => BetaGroupRelationshipsBetaRecruitmentCriteriaDataType.BetaRecruitmentCriteria,
                _ => null,
            };
        }
    }
}