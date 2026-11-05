
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOfferUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferUpdateRequestDataType value)
        {
            return value switch
            {
                RetentionOfferUpdateRequestDataType.RetentionOffers => "retentionOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOffers" => RetentionOfferUpdateRequestDataType.RetentionOffers,
                _ => null,
            };
        }
    }
}