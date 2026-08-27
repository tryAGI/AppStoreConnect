
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildIndividualTestersLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildIndividualTestersLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildIndividualTestersLinkagesRequestDataItemType value)
        {
            return value switch
            {
                BuildIndividualTestersLinkagesRequestDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildIndividualTestersLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BuildIndividualTestersLinkagesRequestDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}