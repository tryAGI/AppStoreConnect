
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdsGetInstanceIncludeItem value)
        {
            return value switch
            {
                MerchantIdsGetInstanceIncludeItem.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => MerchantIdsGetInstanceIncludeItem.Certificates,
                _ => null,
            };
        }
    }
}