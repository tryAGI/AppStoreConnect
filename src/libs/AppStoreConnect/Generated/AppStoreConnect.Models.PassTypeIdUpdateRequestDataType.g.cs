
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PassTypeIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdUpdateRequestDataType value)
        {
            return value switch
            {
                PassTypeIdUpdateRequestDataType.PassTypeIds => "passTypeIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "passTypeIds" => PassTypeIdUpdateRequestDataType.PassTypeIds,
                _ => null,
            };
        }
    }
}