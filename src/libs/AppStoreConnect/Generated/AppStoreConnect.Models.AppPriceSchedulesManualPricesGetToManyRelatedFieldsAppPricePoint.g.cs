
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint
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
    public static class AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint value)
        {
            return value switch
            {
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.App => "app",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.CustomerPrice => "customerPrice",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.Equalizations => "equalizations",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.Proceeds => "proceeds",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.App,
                "customerPrice" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.CustomerPrice,
                "equalizations" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.Equalizations,
                "proceeds" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.Proceeds,
                "territory" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint.Territory,
                _ => null,
            };
        }
    }
}