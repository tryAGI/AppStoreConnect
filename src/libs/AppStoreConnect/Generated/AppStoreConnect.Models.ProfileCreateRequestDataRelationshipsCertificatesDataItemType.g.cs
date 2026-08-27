
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileCreateRequestDataRelationshipsCertificatesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Certificates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileCreateRequestDataRelationshipsCertificatesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileCreateRequestDataRelationshipsCertificatesDataItemType value)
        {
            return value switch
            {
                ProfileCreateRequestDataRelationshipsCertificatesDataItemType.Certificates => "certificates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileCreateRequestDataRelationshipsCertificatesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "certificates" => ProfileCreateRequestDataRelationshipsCertificatesDataItemType.Certificates,
                _ => null,
            };
        }
    }
}