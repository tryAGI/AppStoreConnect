
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerPrice,
        /// <summary>
        /// 
        /// </summary>
        Equalizations,
        /// <summary>
        /// 
        /// </summary>
        Proceeds,
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.CustomerPrice => "customerPrice",
                InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.Equalizations => "equalizations",
                InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.Proceeds => "proceeds",
                InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint? ToEnum(string value)
        {
            return value switch
            {
                "customerPrice" => InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.CustomerPrice,
                "equalizations" => InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.Equalizations,
                "proceeds" => InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.Proceeds,
                "territory" => InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint.Territory,
                _ => null,
            };
        }
    }
}