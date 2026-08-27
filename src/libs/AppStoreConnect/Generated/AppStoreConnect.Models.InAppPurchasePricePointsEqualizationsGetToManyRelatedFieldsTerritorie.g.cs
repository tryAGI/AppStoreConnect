
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}