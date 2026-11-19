
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint
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
    public static class SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}