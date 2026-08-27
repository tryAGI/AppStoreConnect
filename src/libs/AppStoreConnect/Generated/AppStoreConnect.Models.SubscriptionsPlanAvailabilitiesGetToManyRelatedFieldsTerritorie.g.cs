
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}