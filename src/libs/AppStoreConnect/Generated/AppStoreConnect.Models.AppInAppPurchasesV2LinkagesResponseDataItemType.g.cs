
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInAppPurchasesV2LinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInAppPurchasesV2LinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInAppPurchasesV2LinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppInAppPurchasesV2LinkagesResponseDataItemType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInAppPurchasesV2LinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => AppInAppPurchasesV2LinkagesResponseDataItemType.InAppPurchases,
                _ => null,
            };
        }
    }
}