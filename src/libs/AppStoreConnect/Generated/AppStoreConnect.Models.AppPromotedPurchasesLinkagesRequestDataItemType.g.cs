
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPromotedPurchasesLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPromotedPurchasesLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPromotedPurchasesLinkagesRequestDataItemType value)
        {
            return value switch
            {
                AppPromotedPurchasesLinkagesRequestDataItemType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPromotedPurchasesLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => AppPromotedPurchasesLinkagesRequestDataItemType.PromotedPurchases,
                _ => null,
            };
        }
    }
}