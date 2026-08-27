
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupBuildsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupBuildsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupBuildsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                BetaGroupBuildsLinkagesRequestDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupBuildsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaGroupBuildsLinkagesRequestDataItemType.Builds,
                _ => null,
            };
        }
    }
}