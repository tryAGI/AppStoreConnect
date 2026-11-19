
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint
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
    public static class SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}