
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferCreateRequestDataType value)
        {
            return value switch
            {
                RetentionOfferCreateRequestDataType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => RetentionOfferCreateRequestDataType.RetentionOffers,
                _ => null,
            };
        }
    }
}