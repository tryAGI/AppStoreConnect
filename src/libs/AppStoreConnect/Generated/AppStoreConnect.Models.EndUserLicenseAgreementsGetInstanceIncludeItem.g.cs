
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndUserLicenseAgreementsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserLicenseAgreementsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementsGetInstanceIncludeItem value)
        {
            return value switch
            {
                EndUserLicenseAgreementsGetInstanceIncludeItem.App => "app",
                EndUserLicenseAgreementsGetInstanceIncludeItem.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => EndUserLicenseAgreementsGetInstanceIncludeItem.App,
                "territories" => EndUserLicenseAgreementsGetInstanceIncludeItem.Territories,
                _ => null,
            };
        }
    }
}