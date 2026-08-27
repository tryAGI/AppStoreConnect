
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint
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
    public static class AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint value)
        {
            return value switch
            {
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.App => "app",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.CustomerPrice => "customerPrice",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.Equalizations => "equalizations",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.Proceeds => "proceeds",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.App,
                "customerPrice" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.CustomerPrice,
                "equalizations" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.Equalizations,
                "proceeds" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.Proceeds,
                "territory" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint.Territory,
                _ => null,
            };
        }
    }
}