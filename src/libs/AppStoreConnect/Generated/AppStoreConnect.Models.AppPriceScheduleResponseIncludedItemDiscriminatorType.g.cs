
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceScheduleResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppPrices,
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppPriceScheduleResponseIncludedItemDiscriminatorType.AppPrices => "appPrices",
                AppPriceScheduleResponseIncludedItemDiscriminatorType.Apps => "apps",
                AppPriceScheduleResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appPrices" => AppPriceScheduleResponseIncludedItemDiscriminatorType.AppPrices,
                "apps" => AppPriceScheduleResponseIncludedItemDiscriminatorType.Apps,
                "territories" => AppPriceScheduleResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}