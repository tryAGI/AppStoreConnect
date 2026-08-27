
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceSchedulesGetInstanceFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceSchedulesGetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesGetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                AppPriceSchedulesGetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesGetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AppPriceSchedulesGetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}