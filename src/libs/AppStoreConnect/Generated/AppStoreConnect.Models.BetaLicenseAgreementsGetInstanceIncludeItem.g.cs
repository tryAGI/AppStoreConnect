
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaLicenseAgreementsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLicenseAgreementsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaLicenseAgreementsGetInstanceIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaLicenseAgreementsGetInstanceIncludeItem.App,
                _ => null,
            };
        }
    }
}