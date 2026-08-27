
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        WinBackOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOfferCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferCreateRequestDataType value)
        {
            return value switch
            {
                WinBackOfferCreateRequestDataType.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOffers" => WinBackOfferCreateRequestDataType.WinBackOffers,
                _ => null,
            };
        }
    }
}