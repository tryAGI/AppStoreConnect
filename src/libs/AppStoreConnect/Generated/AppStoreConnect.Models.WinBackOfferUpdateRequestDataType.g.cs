
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        WinBackOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOfferUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferUpdateRequestDataType value)
        {
            return value switch
            {
                WinBackOfferUpdateRequestDataType.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOffers" => WinBackOfferUpdateRequestDataType.WinBackOffers,
                _ => null,
            };
        }
    }
}