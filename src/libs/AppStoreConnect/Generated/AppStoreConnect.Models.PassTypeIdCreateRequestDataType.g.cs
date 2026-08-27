
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PassTypeIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdCreateRequestDataType value)
        {
            return value switch
            {
                PassTypeIdCreateRequestDataType.PassTypeIds => "passTypeIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "passTypeIds" => PassTypeIdCreateRequestDataType.PassTypeIds,
                _ => null,
            };
        }
    }
}