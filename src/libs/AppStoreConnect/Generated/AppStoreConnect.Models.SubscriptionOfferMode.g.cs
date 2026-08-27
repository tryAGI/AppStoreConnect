
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferMode
    {
        /// <summary>
        ///
        /// </summary>
        FreeTrial,
        /// <summary>
        ///
        /// </summary>
        PayAsYouGo,
        /// <summary>
        ///
        /// </summary>
        PayUpFront,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferMode value)
        {
            return value switch
            {
                SubscriptionOfferMode.FreeTrial => "FREE_TRIAL",
                SubscriptionOfferMode.PayAsYouGo => "PAY_AS_YOU_GO",
                SubscriptionOfferMode.PayUpFront => "PAY_UP_FRONT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferMode? ToEnum(string value)
        {
            return value switch
            {
                "FREE_TRIAL" => SubscriptionOfferMode.FreeTrial,
                "PAY_AS_YOU_GO" => SubscriptionOfferMode.PayAsYouGo,
                "PAY_UP_FRONT" => SubscriptionOfferMode.PayUpFront,
                _ => null,
            };
        }
    }
}