
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfileRelationshipsCertificatesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileRelationshipsCertificatesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileRelationshipsCertificatesDataItemType value)
        {
            return value switch
            {
                ProfileRelationshipsCertificatesDataItemType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileRelationshipsCertificatesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => ProfileRelationshipsCertificatesDataItemType.Certificates,
                _ => null,
            };
        }
    }
}