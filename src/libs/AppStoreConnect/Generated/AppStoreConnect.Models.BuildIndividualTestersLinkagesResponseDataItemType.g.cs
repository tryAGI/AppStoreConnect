
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildIndividualTestersLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildIndividualTestersLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildIndividualTestersLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BuildIndividualTestersLinkagesResponseDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildIndividualTestersLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BuildIndividualTestersLinkagesResponseDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}