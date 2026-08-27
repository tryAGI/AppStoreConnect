
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroupDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroupDataType value)
        {
            return value switch
            {
                BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroupDataType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BetaRecruitmentCriterionCreateRequestDataRelationshipsBetaGroupDataType.BetaGroups,
                _ => null,
            };
        }
    }
}