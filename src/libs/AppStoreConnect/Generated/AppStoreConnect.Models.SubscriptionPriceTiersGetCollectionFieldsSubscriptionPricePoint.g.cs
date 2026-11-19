
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint
    {
        /// <summary>
        ///
        /// </summary>
        AdjustedEqualizations,
        /// <summary>
        ///
        /// </summary>
        CustomerPrice,
        /// <summary>
        ///
        /// </summary>
        Equalizations,
        /// <summary>
        ///
        /// </summary>
        Proceeds,
        /// <summary>
        ///
        /// </summary>
        ProceedsYear2,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}