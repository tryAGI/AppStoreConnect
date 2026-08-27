
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint
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
    public static class AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint value)
        {
            return value switch
            {
                AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.App => "app",
                AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.CustomerPrice => "customerPrice",
                AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.Equalizations => "equalizations",
                AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.Proceeds => "proceeds",
                AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.App,
                "customerPrice" => AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.CustomerPrice,
                "equalizations" => AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.Equalizations,
                "proceeds" => AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.Proceeds,
                "territory" => AppPricePointsV3EqualizationsGetToManyRelatedFieldsAppPricePoint.Territory,
                _ => null,
            };
        }
    }
}