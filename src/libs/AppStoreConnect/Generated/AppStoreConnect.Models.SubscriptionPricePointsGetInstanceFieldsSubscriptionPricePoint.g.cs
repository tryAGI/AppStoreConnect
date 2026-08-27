
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint
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
    public static class SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}