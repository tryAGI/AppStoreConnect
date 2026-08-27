
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint
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
    public static class SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint value)
        {
            return value switch
            {
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations => "adjustedEqualizations",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice => "customerPrice",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations => "equalizations",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds => "proceeds",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2 => "proceedsYear2",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "adjustedEqualizations" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.AdjustedEqualizations,
                "customerPrice" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.CustomerPrice,
                "equalizations" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.Equalizations,
                "proceeds" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.Proceeds,
                "proceedsYear2" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.ProceedsYear2,
                "territory" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint.Territory,
                _ => null,
            };
        }
    }
}