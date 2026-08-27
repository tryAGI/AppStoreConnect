
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTesterAppsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterAppsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterAppsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                BetaTesterAppsLinkagesRequestDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterAppsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaTesterAppsLinkagesRequestDataItemType.Apps,
                _ => null,
            };
        }
    }
}