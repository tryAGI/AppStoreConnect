
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PassTypeIdsGetCollectionFieldsPassTypeId
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
    public static class PassTypeIdsGetCollectionFieldsPassTypeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsGetCollectionFieldsPassTypeId value)
        {
            return value switch
            {
                PassTypeIdsGetCollectionFieldsPassTypeId.Certificates => "certificates",
                PassTypeIdsGetCollectionFieldsPassTypeId.Identifier => "identifier",
                PassTypeIdsGetCollectionFieldsPassTypeId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsGetCollectionFieldsPassTypeId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => PassTypeIdsGetCollectionFieldsPassTypeId.Certificates,
                "identifier" => PassTypeIdsGetCollectionFieldsPassTypeId.Identifier,
                "name" => PassTypeIdsGetCollectionFieldsPassTypeId.Name,
                _ => null,
            };
        }
    }
}