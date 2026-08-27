
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupBuildsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupBuildsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupBuildsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BetaGroupBuildsLinkagesResponseDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupBuildsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaGroupBuildsLinkagesResponseDataItemType.Builds,
                _ => null,
            };
        }
    }
}