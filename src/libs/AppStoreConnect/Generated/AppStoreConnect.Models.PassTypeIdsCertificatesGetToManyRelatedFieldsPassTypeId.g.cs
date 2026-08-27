
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId
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
    public static class PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId value)
        {
            return value switch
            {
                PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId.Certificates => "certificates",
                PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId.Identifier => "identifier",
                PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId.Certificates,
                "identifier" => PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId.Identifier,
                "name" => PassTypeIdsCertificatesGetToManyRelatedFieldsPassTypeId.Name,
                _ => null,
            };
        }
    }
}