
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferDuration
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
        ThreeDays,
        /// <summary>
        /// 
        /// </summary>
        ThreeMonths,
        /// <summary>
        /// 
        /// </summary>
        TwoMonths,
        /// <summary>
        /// 
        /// </summary>
        TwoWeeks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferDuration value)
        {
            return value switch
            {
                SubscriptionOfferDuration.OneMonth => "ONE_MONTH",
                SubscriptionOfferDuration.OneWeek => "ONE_WEEK",
                SubscriptionOfferDuration.OneYear => "ONE_YEAR",
                SubscriptionOfferDuration.SixMonths => "SIX_MONTHS",
                SubscriptionOfferDuration.ThreeDays => "THREE_DAYS",
                SubscriptionOfferDuration.ThreeMonths => "THREE_MONTHS",
                SubscriptionOfferDuration.TwoMonths => "TWO_MONTHS",
                SubscriptionOfferDuration.TwoWeeks => "TWO_WEEKS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferDuration? ToEnum(string value)
        {
            return value switch
            {
                "ONE_MONTH" => SubscriptionOfferDuration.OneMonth,
                "ONE_WEEK" => SubscriptionOfferDuration.OneWeek,
                "ONE_YEAR" => SubscriptionOfferDuration.OneYear,
                "SIX_MONTHS" => SubscriptionOfferDuration.SixMonths,
                "THREE_DAYS" => SubscriptionOfferDuration.ThreeDays,
                "THREE_MONTHS" => SubscriptionOfferDuration.ThreeMonths,
                "TWO_MONTHS" => SubscriptionOfferDuration.TwoMonths,
                "TWO_WEEKS" => SubscriptionOfferDuration.TwoWeeks,
                _ => null,
            };
        }
    }
}