
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupsResponseIncludedItemDiscriminatorType
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
    public static class BetaGroupsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaGroupsResponseIncludedItemDiscriminatorType.Apps => "apps",
                BetaGroupsResponseIncludedItemDiscriminatorType.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaGroupsResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BetaGroupsResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaGroupsResponseIncludedItemDiscriminatorType.Apps,
                "betaRecruitmentCriteria" => BetaGroupsResponseIncludedItemDiscriminatorType.BetaRecruitmentCriteria,
                "betaTesters" => BetaGroupsResponseIncludedItemDiscriminatorType.BetaTesters,
                "builds" => BetaGroupsResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}