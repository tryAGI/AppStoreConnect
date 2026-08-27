
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseLocalizationV2Type
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseLocalizationV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationV2Type value)
        {
            return value switch
            {
                InAppPurchaseLocalizationV2Type.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationV2Type? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseLocalizations" => InAppPurchaseLocalizationV2Type.InAppPurchaseLocalizations,
                _ => null,
            };
        }
    }
}