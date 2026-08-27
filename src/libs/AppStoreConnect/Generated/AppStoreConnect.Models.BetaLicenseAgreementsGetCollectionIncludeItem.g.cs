
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaLicenseAgreementsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLicenseAgreementsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementsGetCollectionIncludeItem value)
        {
            return value switch
            {
                BetaLicenseAgreementsGetCollectionIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BetaLicenseAgreementsGetCollectionIncludeItem.App,
                _ => null,
            };
        }
    }
}