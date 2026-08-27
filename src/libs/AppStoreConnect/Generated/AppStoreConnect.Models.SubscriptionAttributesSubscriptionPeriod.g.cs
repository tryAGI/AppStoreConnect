
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAttributesSubscriptionPeriod
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
    public static class SubscriptionAttributesSubscriptionPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAttributesSubscriptionPeriod value)
        {
            return value switch
            {
                SubscriptionAttributesSubscriptionPeriod.OneMonth => "ONE_MONTH",
                SubscriptionAttributesSubscriptionPeriod.OneWeek => "ONE_WEEK",
                SubscriptionAttributesSubscriptionPeriod.OneYear => "ONE_YEAR",
                SubscriptionAttributesSubscriptionPeriod.SixMonths => "SIX_MONTHS",
                SubscriptionAttributesSubscriptionPeriod.ThreeMonths => "THREE_MONTHS",
                SubscriptionAttributesSubscriptionPeriod.TwoMonths => "TWO_MONTHS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAttributesSubscriptionPeriod? ToEnum(string value)
        {
            return value switch
            {
                "ONE_MONTH" => SubscriptionAttributesSubscriptionPeriod.OneMonth,
                "ONE_WEEK" => SubscriptionAttributesSubscriptionPeriod.OneWeek,
                "ONE_YEAR" => SubscriptionAttributesSubscriptionPeriod.OneYear,
                "SIX_MONTHS" => SubscriptionAttributesSubscriptionPeriod.SixMonths,
                "THREE_MONTHS" => SubscriptionAttributesSubscriptionPeriod.ThreeMonths,
                "TWO_MONTHS" => SubscriptionAttributesSubscriptionPeriod.TwoMonths,
                _ => null,
            };
        }
    }
}