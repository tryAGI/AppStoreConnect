
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPromotedPurchasesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPromotedPurchasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPromotedPurchasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPromotedPurchasesLinkagesResponseDataItemType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPromotedPurchasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => AppPromotedPurchasesLinkagesResponseDataItemType.PromotedPurchases,
                _ => null,
            };
        }
    }
}