
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildRelationshipsIndividualTestersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsIndividualTestersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsIndividualTestersDataItemType value)
        {
            return value switch
            {
                BuildRelationshipsIndividualTestersDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsIndividualTestersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BuildRelationshipsIndividualTestersDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}