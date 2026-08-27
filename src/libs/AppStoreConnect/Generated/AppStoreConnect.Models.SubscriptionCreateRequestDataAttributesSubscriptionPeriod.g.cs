
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionCreateRequestDataAttributesSubscriptionPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        OneMonth,
        /// <summary>
        /// 
        /// </summary>
        OneWeek,
        /// <summary>
        /// 
        /// </summary>
        OneYear,
        /// <summary>
        /// 
        /// </summary>
        SixMonths,
        /// <summary>
        /// 
        /// </summary>
        ThreeMonths,
        /// <summary>
        /// 
        /// </summary>
        TwoMonths,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionCreateRequestDataAttributesSubscriptionPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionCreateRequestDataAttributesSubscriptionPeriod value)
        {
            return value switch
            {
                SubscriptionCreateRequestDataAttributesSubscriptionPeriod.OneMonth => "ONE_MONTH",
                SubscriptionCreateRequestDataAttributesSubscriptionPeriod.OneWeek => "ONE_WEEK",
                SubscriptionCreateRequestDataAttributesSubscriptionPeriod.OneYear => "ONE_YEAR",
                SubscriptionCreateRequestDataAttributesSubscriptionPeriod.SixMonths => "SIX_MONTHS",
                SubscriptionCreateRequestDataAttributesSubscriptionPeriod.ThreeMonths => "THREE_MONTHS",
                SubscriptionCreateRequestDataAttributesSubscriptionPeriod.TwoMonths => "TWO_MONTHS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionCreateRequestDataAttributesSubscriptionPeriod? ToEnum(string value)
        {
            return value switch
            {
                "ONE_MONTH" => SubscriptionCreateRequestDataAttributesSubscriptionPeriod.OneMonth,
                "ONE_WEEK" => SubscriptionCreateRequestDataAttributesSubscriptionPeriod.OneWeek,
                "ONE_YEAR" => SubscriptionCreateRequestDataAttributesSubscriptionPeriod.OneYear,
                "SIX_MONTHS" => SubscriptionCreateRequestDataAttributesSubscriptionPeriod.SixMonths,
                "THREE_MONTHS" => SubscriptionCreateRequestDataAttributesSubscriptionPeriod.ThreeMonths,
                "TWO_MONTHS" => SubscriptionCreateRequestDataAttributesSubscriptionPeriod.TwoMonths,
                _ => null,
            };
        }
    }
}