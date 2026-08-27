
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
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
    public static class BetaGroupsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaGroupsGetInstanceIncludeItem.App => "app",
                BetaGroupsGetInstanceIncludeItem.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaGroupsGetInstanceIncludeItem.BetaTesters => "betaTesters",
                BetaGroupsGetInstanceIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaGroupsGetInstanceIncludeItem.App,
                "betaRecruitmentCriteria" => BetaGroupsGetInstanceIncludeItem.BetaRecruitmentCriteria,
                "betaTesters" => BetaGroupsGetInstanceIncludeItem.BetaTesters,
                "builds" => BetaGroupsGetInstanceIncludeItem.Builds,
                _ => null,
            };
        }
    }
}