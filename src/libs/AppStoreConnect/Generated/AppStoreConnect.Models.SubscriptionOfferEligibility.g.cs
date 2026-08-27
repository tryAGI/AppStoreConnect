
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferEligibility
    {
        /// <summary>
        /// 
        /// </summary>
        ReplaceIntroOffers,
        /// <summary>
        /// 
        /// </summary>
        StackWithIntroOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferEligibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferEligibility value)
        {
            return value switch
            {
                SubscriptionOfferEligibility.ReplaceIntroOffers => "REPLACE_INTRO_OFFERS",
                SubscriptionOfferEligibility.StackWithIntroOffers => "STACK_WITH_INTRO_OFFERS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferEligibility? ToEnum(string value)
        {
            return value switch
            {
                "REPLACE_INTRO_OFFERS" => SubscriptionOfferEligibility.ReplaceIntroOffers,
                "STACK_WITH_INTRO_OFFERS" => SubscriptionOfferEligibility.StackWithIntroOffers,
                _ => null,
            };
        }
    }
}