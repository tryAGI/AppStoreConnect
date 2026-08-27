
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdsGetInstanceFieldsPassTypeId
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
        /// <summary>
        /// 
        /// </summary>
        Identifier,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PassTypeIdsGetInstanceFieldsPassTypeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsGetInstanceFieldsPassTypeId value)
        {
            return value switch
            {
                PassTypeIdsGetInstanceFieldsPassTypeId.Certificates => "certificates",
                PassTypeIdsGetInstanceFieldsPassTypeId.Identifier => "identifier",
                PassTypeIdsGetInstanceFieldsPassTypeId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsGetInstanceFieldsPassTypeId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => PassTypeIdsGetInstanceFieldsPassTypeId.Certificates,
                "identifier" => PassTypeIdsGetInstanceFieldsPassTypeId.Identifier,
                "name" => PassTypeIdsGetInstanceFieldsPassTypeId.Name,
                _ => null,
            };
        }
    }
}