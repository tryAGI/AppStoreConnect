
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint
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
    public static class InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint value)
        {
            return value switch
            {
                InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice => "customerPrice",
                InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations => "equalizations",
                InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds => "proceeds",
                InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint? ToEnum(string value)
        {
            return value switch
            {
                "customerPrice" => InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.CustomerPrice,
                "equalizations" => InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.Equalizations,
                "proceeds" => InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.Proceeds,
                "territory" => InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint.Territory,
                _ => null,
            };
        }
    }
}