
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetCollectionIncludeItem
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
    public static class BetaGroupsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BetaGroupsGetCollectionIncludeItem.App => "app",
                BetaGroupsGetCollectionIncludeItem.BetaRecruitmentCriteria => "betaRecruitmentCriteria",
                BetaGroupsGetCollectionIncludeItem.BetaTesters => "betaTesters",
                BetaGroupsGetCollectionIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaGroupsGetCollectionIncludeItem.App,
                "betaRecruitmentCriteria" => BetaGroupsGetCollectionIncludeItem.BetaRecruitmentCriteria,
                "betaTesters" => BetaGroupsGetCollectionIncludeItem.BetaTesters,
                "builds" => BetaGroupsGetCollectionIncludeItem.Builds,
                _ => null,
            };
        }
    }
}