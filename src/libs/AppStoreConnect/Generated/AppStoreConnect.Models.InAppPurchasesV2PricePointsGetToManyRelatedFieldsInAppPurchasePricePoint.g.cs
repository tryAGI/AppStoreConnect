
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint
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
    public static class InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint value)
        {
            return value switch
            {
                InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice => "customerPrice",
                InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations => "equalizations",
                InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds => "proceeds",
                InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint? ToEnum(string value)
        {
            return value switch
            {
                "customerPrice" => InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice,
                "equalizations" => InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations,
                "proceeds" => InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds,
                "territory" => InAppPurchasesV2PricePointsGetToManyRelatedFieldsInAppPurchasePricePoint.Territory,
                _ => null,
            };
        }
    }
}