
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterBuildsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterBuildsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterBuildsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BetaTesterBuildsLinkagesResponseDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterBuildsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaTesterBuildsLinkagesResponseDataItemType.Builds,
                _ => null,
            };
        }
    }
}