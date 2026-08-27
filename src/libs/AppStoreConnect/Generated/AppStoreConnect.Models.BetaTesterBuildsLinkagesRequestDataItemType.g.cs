
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterBuildsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterBuildsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterBuildsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                BetaTesterBuildsLinkagesRequestDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterBuildsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaTesterBuildsLinkagesRequestDataItemType.Builds,
                _ => null,
            };
        }
    }
}