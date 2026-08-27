
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MerchantIdUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        MerchantIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdUpdateRequestDataType value)
        {
            return value switch
            {
                MerchantIdUpdateRequestDataType.MerchantIds => "merchantIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "merchantIds" => MerchantIdUpdateRequestDataType.MerchantIds,
                _ => null,
            };
        }
    }
}