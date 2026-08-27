
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointsV3GetInstanceFieldsAppPricePoint
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
    public static class AppPricePointsV3GetInstanceFieldsAppPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointsV3GetInstanceFieldsAppPricePoint value)
        {
            return value switch
            {
                AppPricePointsV3GetInstanceFieldsAppPricePoint.App => "app",
                AppPricePointsV3GetInstanceFieldsAppPricePoint.CustomerPrice => "customerPrice",
                AppPricePointsV3GetInstanceFieldsAppPricePoint.Equalizations => "equalizations",
                AppPricePointsV3GetInstanceFieldsAppPricePoint.Proceeds => "proceeds",
                AppPricePointsV3GetInstanceFieldsAppPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointsV3GetInstanceFieldsAppPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPricePointsV3GetInstanceFieldsAppPricePoint.App,
                "customerPrice" => AppPricePointsV3GetInstanceFieldsAppPricePoint.CustomerPrice,
                "equalizations" => AppPricePointsV3GetInstanceFieldsAppPricePoint.Equalizations,
                "proceeds" => AppPricePointsV3GetInstanceFieldsAppPricePoint.Proceeds,
                "territory" => AppPricePointsV3GetInstanceFieldsAppPricePoint.Territory,
                _ => null,
            };
        }
    }
}