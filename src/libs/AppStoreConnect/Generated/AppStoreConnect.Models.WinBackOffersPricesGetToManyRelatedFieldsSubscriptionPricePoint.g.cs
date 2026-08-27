
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint
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
    public static class WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}