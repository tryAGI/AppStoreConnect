
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}