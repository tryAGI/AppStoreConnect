
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}