
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionUpdateRequestDataAttributesSubscriptionPeriod
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
    public static class SubscriptionUpdateRequestDataAttributesSubscriptionPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionUpdateRequestDataAttributesSubscriptionPeriod value)
        {
            return value switch
            {
                SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.OneMonth => "ONE_MONTH",
                SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.OneWeek => "ONE_WEEK",
                SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.OneYear => "ONE_YEAR",
                SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.SixMonths => "SIX_MONTHS",
                SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.ThreeMonths => "THREE_MONTHS",
                SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.TwoMonths => "TWO_MONTHS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionUpdateRequestDataAttributesSubscriptionPeriod? ToEnum(string value)
        {
            return value switch
            {
                "ONE_MONTH" => SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.OneMonth,
                "ONE_WEEK" => SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.OneWeek,
                "ONE_YEAR" => SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.OneYear,
                "SIX_MONTHS" => SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.SixMonths,
                "THREE_MONTHS" => SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.ThreeMonths,
                "TWO_MONTHS" => SubscriptionUpdateRequestDataAttributesSubscriptionPeriod.TwoMonths,
                _ => null,
            };
        }
    }
}