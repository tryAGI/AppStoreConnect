
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferType value)
        {
            return value switch
            {
                RetentionOfferType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => RetentionOfferType.RetentionOffers,
                _ => null,
            };
        }
    }
}