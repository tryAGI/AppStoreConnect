
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsInAppPurchasesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsInAppPurchasesGetToManyRelatedIncludeItem.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppsInAppPurchasesGetToManyRelatedIncludeItem.Apps,
                _ => null,
            };
        }
    }
}