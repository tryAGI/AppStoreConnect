
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint
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
    public static class SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}