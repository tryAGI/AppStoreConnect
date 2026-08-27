
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsPromotedPurchasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        PromotedPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsPromotedPurchasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsPromotedPurchasesDataItemType value)
        {
            return value switch
            {
                AppRelationshipsPromotedPurchasesDataItemType.PromotedPurchases => "promotedPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsPromotedPurchasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "promotedPurchases" => AppRelationshipsPromotedPurchasesDataItemType.PromotedPurchases,
                _ => null,
            };
        }
    }
}