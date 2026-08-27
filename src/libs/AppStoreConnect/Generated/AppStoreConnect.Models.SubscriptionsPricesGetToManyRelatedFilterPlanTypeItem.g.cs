
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Upfront,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsPricesGetToManyRelatedFilterPlanTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem value)
        {
            return value switch
            {
                SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem.Monthly => "MONTHLY",
                SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem.Upfront => "UPFRONT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "MONTHLY" => SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem.Monthly,
                "UPFRONT" => SubscriptionsPricesGetToManyRelatedFilterPlanTypeItem.Upfront,
                _ => null,
            };
        }
    }
}