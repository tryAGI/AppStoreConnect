
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MerchantIdCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        MerchantIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MerchantIdCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MerchantIdCreateRequestDataType value)
        {
            return value switch
            {
                MerchantIdCreateRequestDataType.MerchantIds => "merchantIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MerchantIdCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "merchantIds" => MerchantIdCreateRequestDataType.MerchantIds,
                _ => null,
            };
        }
    }
}