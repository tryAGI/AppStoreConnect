
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        BetaRecruitmentCriteria,
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaGroupResponseIncludedItemDiscriminatorType.Apps => "apps",
                BetaGroupResponseIncludedItemDiscriminatorType.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaGroupResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BetaGroupResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaGroupResponseIncludedItemDiscriminatorType.Apps,
                "betaRecruitmentCriteria" => BetaGroupResponseIncludedItemDiscriminatorType.BetaRecruitmentCriteria,
                "betaTesters" => BetaGroupResponseIncludedItemDiscriminatorType.BetaTesters,
                "builds" => BetaGroupResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}