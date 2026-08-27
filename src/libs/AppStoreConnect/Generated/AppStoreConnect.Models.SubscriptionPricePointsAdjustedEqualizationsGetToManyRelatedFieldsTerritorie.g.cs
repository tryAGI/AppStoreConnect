
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => SubscriptionPricePointsAdjustedEqualizationsGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}