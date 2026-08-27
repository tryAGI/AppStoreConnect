
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPricePointsV3GetInstanceFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricePointsV3GetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointsV3GetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                AppPricePointsV3GetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointsV3GetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AppPricePointsV3GetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}