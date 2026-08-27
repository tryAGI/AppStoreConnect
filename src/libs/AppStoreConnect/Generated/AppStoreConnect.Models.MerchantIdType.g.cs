
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MerchantIdType
    {
        /// <summary>
        ///
        /// </summary>
        MerchantIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdType value)
        {
            return value switch
            {
                MerchantIdType.MerchantIds => "merchantIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdType? ToEnum(string value)
        {
            return value switch
            {
                "merchantIds" => MerchantIdType.MerchantIds,
                _ => null,
            };
        }
    }
}