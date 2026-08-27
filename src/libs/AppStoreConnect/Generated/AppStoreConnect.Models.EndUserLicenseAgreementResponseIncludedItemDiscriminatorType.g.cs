
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                EndUserLicenseAgreementResponseIncludedItemDiscriminatorType.Apps => "apps",
                EndUserLicenseAgreementResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => EndUserLicenseAgreementResponseIncludedItemDiscriminatorType.Apps,
                "territories" => EndUserLicenseAgreementResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}