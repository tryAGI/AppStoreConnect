
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint
    {
        /// <summary>
        /// 
        /// </summary>
        App,
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
    public static class AppsAppPricePointsGetToManyRelatedFieldsAppPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint value)
        {
            return value switch
            {
                AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.App => "app",
                AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.CustomerPrice => "customerPrice",
                AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.Equalizations => "equalizations",
                AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.Proceeds => "proceeds",
                AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.App,
                "customerPrice" => AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.CustomerPrice,
                "equalizations" => AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.Equalizations,
                "proceeds" => AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.Proceeds,
                "territory" => AppsAppPricePointsGetToManyRelatedFieldsAppPricePoint.Territory,
                _ => null,
            };
        }
    }
}