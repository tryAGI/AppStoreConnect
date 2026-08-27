
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint
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
    public static class SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}