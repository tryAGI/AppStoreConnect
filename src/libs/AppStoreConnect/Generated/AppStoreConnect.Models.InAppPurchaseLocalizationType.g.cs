
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseLocalizationType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationType value)
        {
            return value switch
            {
                InAppPurchaseLocalizationType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseLocalizations" => InAppPurchaseLocalizationType.InAppPurchaseLocalizations,
                _ => null,
            };
        }
    }
}