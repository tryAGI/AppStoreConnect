
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "territory" => InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}